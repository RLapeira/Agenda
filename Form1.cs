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
            dtpFechaNac.Value = System.DateTime.Today;
            tbTelefono.Text = null;
            tbObservaciones.Text = null;
        }

        private void HabilitarCampos()
        {
            tbNombre.Enabled = true;
            dtpFechaNac.Enabled = true;
            dtpFechaNac.MaxDate = DateTime.Today;
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

        private bool ComprobarCampos()
        {
            bool ok = true;

            if(tbNombre.Text.Length == 0 || tbNombre.Text.Length > 100)
            {
                ok = false;
            }

            if(tbTelefono.Text.Length != 9 || int.TryParse(tbTelefono.Text, out int aux))
            {
                ok = false;
            }

            if (tbObservaciones.Text.Length > 500)
            {
                ok = false;
            }

            return ok;
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

            HabilitarBotones();
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
            if(ComprobarCampos())
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

                btmNuevo.Enabled = true;

                DeshabilitarCampos();
            }
            else
            {
                MessageBox.Show("Alguno de los campos introducidos es incorrecto!");
            }

        }

        private void btmCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();

            btmNuevo.Enabled = true;

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
