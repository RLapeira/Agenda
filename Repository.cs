using System;
using System.Data;
using System.Data.SqlClient;

namespace Agenda
{
    public class Repository
    {
        Context context;
        SqlConnection con;

        List<Contacto> contactos = new List<Contacto>();

        private void Connect()
        {
            context = new Context();
            con = context.Connect();
        }
        private void Disconnect()
        {
            con = context.Disconnect();
        }

        public List<Contacto> getAllContactos()
        {
            Connect();

            List<Contacto> nuevosContactos = new List<Contacto>();

            SqlCommand command = new SqlCommand("ObtenerContactos", con);
            command.CommandType = CommandType.StoredProcedure;
            SqlDataReader dataReader = command.ExecuteReader();

            Contacto contacto;

            while (dataReader.Read())
            {
                contacto = new Contacto((int)dataReader.GetValue(0),
                    (string)dataReader.GetValue(1),
                    (DateTime)dataReader.GetValue(2),
                    (string)dataReader.GetValue(3),
                    (string)dataReader.GetValue(4));

                nuevosContactos.Add(contacto);
            }

            dataReader.Close();
            contactos = nuevosContactos;

            Disconnect();

            return nuevosContactos;
        }

        public Contacto getContacto(int index)
        {
            return contactos[index];
        }

        internal void AddContacto(string nombre, DateTime fechaNacimiento, string telefono, string observaciones)
        {
            Connect();

            SqlTransaction tran = con.BeginTransaction();

            SqlCommand command = new SqlCommand("AñadirContacto", con);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Nombre", nombre);
            command.Parameters.AddWithValue("@FechaNacimiento", fechaNacimiento);
            command.Parameters.AddWithValue("@Telefono", telefono);
            command.Parameters.AddWithValue("@Observaciones", observaciones);
            
            command.Transaction = tran;

            try
            {
                command.ExecuteNonQuery();
                tran.Commit();
            }
            catch (Exception ex)
            {
                tran.Rollback();
            }
            finally
            {
                Disconnect();
            }
        }

        internal void DeleteContacto(string id)
        {
            Connect();

            SqlTransaction tran = con.BeginTransaction();

            SqlCommand command = new SqlCommand("EliminarContacto", con);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Id", id);

            command.Transaction = tran;

            try
            {
                command.ExecuteNonQuery();
                tran.Commit();
            }
            catch (Exception ex)
            {
                tran.Rollback();
            }
            finally
            {
                Disconnect();
            }
        }

        internal void ModificarContacto(int id, string nombre, DateTime fechaNacimiento, string telefono, string observaciones)
        {
            Connect();

            SqlTransaction tran = con.BeginTransaction();

            SqlCommand command = new SqlCommand("ModificarContacto", con);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Id", id);
            command.Parameters.AddWithValue("@Nombre", nombre);
            command.Parameters.AddWithValue("@FechaNacimiento", fechaNacimiento);
            command.Parameters.AddWithValue("@Telefono", telefono);
            command.Parameters.AddWithValue("@Observaciones", observaciones);

            command.Transaction = tran;

            try
            {
                command.ExecuteNonQuery();
                tran.Commit();
            }
            catch (Exception ex)
            {
                tran.Rollback();
            }
            finally
            {
                Disconnect();
            }
        }
    }
}
