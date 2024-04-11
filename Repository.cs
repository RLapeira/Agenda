using System;
using System.Data.SqlClient;

namespace Agenda
{
    public class Repository
    {
        SqlConnection con = new Context().Connect();

        List<Contacto> contactos = new List<Contacto>();

        public List<Contacto> getAllContactos()
        {
            List<Contacto> nuevosContactos = new List<Contacto>();

            string sql = "Select Id, " +
                "Nombre, " +
                "FechaNacimiento, " +
                "Telefono, " +
                "Observaciones " +
                "from dbo.Contactos";
            SqlCommand command = new SqlCommand(sql, con);
            
            SqlDataReader dataReader = command.ExecuteReader();

            Contacto contacto;

            while(dataReader.Read())
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

            return nuevosContactos;
        }

        public Contacto getContacto(int index)
        {
            return contactos[index];
        }

        internal void AddContacto(string nombre, DateTime fechaNacimiento, string telefono, string observaciones)
        {
            string sql = "INSERT INTO [dbo].[Contactos]([Nombre], " +
                "[FechaNacimiento], [Telefono], [Observaciones]) VALUES (\'" +
                nombre + "\', \'" + fechaNacimiento.ToString("yyyy-MM-dd") + "\', \'" + 
                telefono + "\', \'" + observaciones + "\');";
            SqlCommand command = new SqlCommand(sql, con);
            SqlDataReader dataReader = command.ExecuteReader();
            dataReader.Close();
        }

        internal void DeleteContacto(string id)
        {
            string sql = $"DELETE FROM [dbo].[Contactos] WHERE [Id] ={id};";
            SqlCommand command = new SqlCommand(sql, con);
            SqlDataReader dataReader = command.ExecuteReader();
            dataReader.Close();
        }

        internal void ModificarContacto(string id, string nombre, DateTime fechaNacimiento, string telefono, string observaciones)
        {
            string sql = $"UPDATE [dbo].[Contactos] SET [Nombre] = '{nombre}', [FechaNacimiento] = '{fechaNacimiento.ToString("yyyy-MM-dd")}', " +
                $"[Telefono] = '{telefono}', [Observaciones] = '{observaciones}', WHERE [Id] = {id}";
        }
    }
}
