using System;
using System.Data.SqlClient;

namespace Agenda
{
    public class Context
    {
        // Nombre del servidor que contiene la base de datos
        static string DataSource = "WINAPY7QPNFXDES\\SQLEXPRESS04";

        // Nombre de la base de datos
        static string InitialCatalog = "Agenda";

        // Establece si la conexión debe usar seguridad integrada.
        // Si se establece en "SSPI", se utilizará la autenticación de Windows del usuario
        static string IntegratedSecurity = "SSPI";

        // Cadena de conexión
        static string connectionString = $"Data Source={DataSource}; " +
            $"Initial Catalog={InitialCatalog}; " +
            $"Integrated Security={IntegratedSecurity}";

        SqlConnection connection = new SqlConnection(connectionString);

        public void Connect()
        {
            try
            {
                connection.Open();
                Console.WriteLine("Conexión abierta");
            }
            catch (Exception ex)
            {
                Console.WriteLine("¡Error al conectar a la base de datos!\n" + ex.Message);
            }
        }

        public void Disconnect()
        {
            try
            {
                connection.Close();
                connection.Dispose();
            }
            catch (Exception ex)
            {
                Console.WriteLine("¡Error al cerrar la conexión con base de datos!\n" + ex.Message);
            }
        }

    }
}
