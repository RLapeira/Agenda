using System;

namespace Agenda
{
    public partial class Form1 : Form
    {
        Repository rep;
        public Form1()
        {
            InitializeComponent();
            rep = new Repository();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mostrarInfo.DataSource = rep.getAllContactos();
        }

        private void mostrarInfo_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int index = e.RowIndex;
            Contacto c = rep.getContacto(index);
            tbId.Text = c.Id.ToString();
            tbNombre.Text = c.Name;
            dtpFechaNac.Value = c.FechaNacimiento;
            tbTelefono.Text = c.Telefono;
            tbObservaciones.Text = c.Observaciones;
        }

        private void btmAnadir_Click(object sender, EventArgs e)
        {
            rep.AddContacto();
        }
    }
}
