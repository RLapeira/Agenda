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

        // Botones

        private void HabilitarBotones()
        {
            btmNuevo.Enabled = true;
            btmEliminar.Enabled = true;
            btmModificar.Enabled = true;
        }

        private void DeshabilitarBotones()
        {
            btmNuevo.Enabled = false;
            btmEliminar.Enabled = false;
            btmModificar.Enabled = false;
        }

        // Botones Creación
        private void HabilitarBotonesCreacion()
        {
            btmGuardar.Enabled = true;
            btmCancelar.Enabled = true;
        }

        private void DeshabilitarBotonesCreacion()
        {
            btmGuardar.Enabled = false;
            btmCancelar.Enabled = false;
        }

        // Campos
        private void LimpiarCampos()
        {
            tbId.Text = null;
            tbNombre.Text = null;
            dtpFechaNac.Value = System.DateTime.Now;
            tbTelefono.Text = null;
            tbObservaciones.Text = null;
        }

        private void HabilitarCampos()
        {
            tbNombre.Enabled = true;
            dtpFechaNac.Enabled = true;
            tbTelefono.Enabled = true;
            tbObservaciones.Enabled = true;
        }

        private void DeshabilitarCampos()
        {
            tbNombre.Enabled = false;
            dtpFechaNac.Enabled = false;
            tbTelefono.Enabled = false;
            tbObservaciones.Enabled = false;
            btmGuardar.Enabled = false;
            btmCancelar.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mostrarInfo.DataSource = rep.getAllContactos();
        }

        private void recargarDataGrid()
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

            HabilitarBotonesCreacion();
        }

        private void btmNuevo_Click(object sender, EventArgs e)
        {
            HabilitarCampos();

            HabilitarBotonesCreacion();

            LimpiarCampos();

            DeshabilitarBotones();
        }

        private void btmGuardar_Click(object sender, EventArgs e)
        {
            if (tbId.Text.Length == 0)
            {
                rep.AddContacto(tbNombre.Text, dtpFechaNac.Value, tbTelefono.Text, tbObservaciones.Text);
            }
            else
            {
                rep.ModificarContacto(int.Parse(tbId.Text), tbNombre.Text, dtpFechaNac.Value, tbTelefono.Text, tbObservaciones.Text);
            }
            recargarDataGrid();

            DeshabilitarBotonesCreacion();
            HabilitarBotones();
            DeshabilitarCampos();
        }

        private void btmCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();

            HabilitarBotones();

            DeshabilitarCampos();

            DeshabilitarBotonesCreacion();
        }

        private void btmEliminar_Click(object sender, EventArgs e)
        {
            rep.DeleteContacto(tbId.Text);
            recargarDataGrid();
        }

        private void btmModificar_Click(object sender, EventArgs e)
        {
            DeshabilitarBotones();

            HabilitarCampos();

            HabilitarBotonesCreacion();
        }

    }
}
