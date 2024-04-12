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

            string sql = "EXEC dbo.ObtenerContactos;";

            SqlCommand command = new SqlCommand(sql, con); ;
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

            string sql = $"EXEC dbo.AñadirContacto @Nombre = '{nombre}', " +
                $"@FechaNacimiento = '{fechaNacimiento.ToString("yyyy -MM-dd")}', " +
                $"@Telefono = '{telefono}', @Observaciones = '{observaciones}';";
            SqlCommand command = new SqlCommand(sql, con);
            
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

            string sql = $"EXEC dbo.EliminarContacto @Id = {id};";
            SqlCommand command = new SqlCommand(sql, con);

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

            string sql = $"EXEC dbo.ModificarContacto @Id = {id}, @Nombre = '{nombre}', " +
                $"@FechaNacimiento = '{fechaNacimiento.ToString("yyyy -MM-dd")}', " +
                $"@Telefono = '{telefono}', @Observaciones = '{observaciones}';";
            SqlCommand command = new SqlCommand(sql, con);

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
