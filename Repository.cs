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

                contactos.Add(contacto);
            }
            return contactos;
        }

        public Contacto getContacto(int index)
        {
            return contactos[index];
        }
    }
}
