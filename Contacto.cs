using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda
{
    public class Contacto
    {
        private int id;
        private string name;
        private DateTime fechaNacimiento;
        private string telefono;
        private string observaciones;

        public int Id { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Telefono { get; set; }
        public string Observaciones { get; set; }

    }
}
