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

            btmGuardar.Enabled = true;
            btmCancelar.Enabled = true;
        }

        private void btmNuevo_Click(object sender, EventArgs e)
        {
            tbNombre.Enabled = true;
            dtpFechaNac.Enabled = true;
            tbTelefono.Enabled = true;
            tbObservaciones.Enabled = true;
            btmGuardar.Enabled = true;
            btmCancelar.Enabled = true;

            tbId.Text = null;
            tbNombre.Text = null;
            dtpFechaNac.Value = System.DateTime.Now;
            tbTelefono.Text = null;
            tbObservaciones.Text = null;

            btmNuevo.Enabled = false;
            btmEliminar.Enabled = false;
            btmModificar.Enabled = false;
        }

        private void recargarDataGrid()
        {
            mostrarInfo.DataSource = rep.getAllContactos();
        }
        private void btmGuardar_Click(object sender, EventArgs e)
        {
            if (tbId.Text == null)
            {
                rep.AddContacto(tbNombre.Text, dtpFechaNac.Value, tbTelefono.Text, tbObservaciones.Text);
            }
            else
            {
                rep.ModificarContacto(int.Parse(tbId.Text), tbNombre.Text, dtpFechaNac.Value, tbTelefono.Text, tbObservaciones.Text);
            }
            recargarDataGrid();

            btmGuardar.Enabled = false;
            btmCancelar.Enabled = false;

            btmNuevo.Enabled = true;
            btmEliminar.Enabled = true;
            btmModificar.Enabled = true;

            tbNombre.Enabled = false;
            dtpFechaNac.Enabled = false;
            tbTelefono.Enabled = false;
            tbObservaciones.Enabled = false;
            btmGuardar.Enabled = false;
            btmCancelar.Enabled = false;
        }

        private void btmCancelar_Click(object sender, EventArgs e)
        {
            tbId.Text = null;
            tbNombre.Text = null;
            dtpFechaNac.Value = System.DateTime.Now;
            tbTelefono.Text = null;
            tbObservaciones.Text = null;

            btmGuardar.Enabled = false;
            btmCancelar.Enabled = false;

            btmNuevo.Enabled = true;
            btmEliminar.Enabled = true;
            btmModificar.Enabled = true;

            tbNombre.Enabled = false;
            dtpFechaNac.Enabled = false;
            tbTelefono.Enabled = false;
            tbObservaciones.Enabled = false;
            btmGuardar.Enabled = false;
            btmCancelar.Enabled = false;
        }

        private void btmEliminar_Click(object sender, EventArgs e)
        {
            rep.DeleteContacto(tbId.Text);
            recargarDataGrid();
        }

        private void btmModificar_Click(object sender, EventArgs e)
        {
            tbNombre.Enabled = true;
            dtpFechaNac.Enabled = true;
            tbTelefono.Enabled = true;
            tbObservaciones.Enabled = true;
            btmGuardar.Enabled = true;
            btmCancelar.Enabled = true;
        }
    }
}
