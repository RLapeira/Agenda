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

        private bool esNumerico(string telefono)
        {
            bool ok = true;
            int i = 0;
            while (i < telefono.Length)
            {
                if (telefono[i] < 48 || telefono[i] > 57)
                {
                    ok = false;
                }
                i++;
            }
            return ok;
        }

        private bool ComprobarCampos()
        {
            bool ok = true;
            string mensaje = "";

            if(tbNombre.Text.Length == 0)
            {
                ok = false;
                mensaje = "El nombre no puede estar vacío.\n";
            }

            if (tbNombre.Text.Length > 100)
            {
                ok = false;
                mensaje += "El nombre no puede ser más de 100 caracteres.\n";
            }

            if (tbTelefono.Text.Length != 9)
            {
                ok = false;
                mensaje += "El telefono tiene que tener 9 dígitos.\n";
            }

            if(!esNumerico(tbTelefono.Text))
            {
                ok = false;
                mensaje += "El telefono tiene que ser un número.\n";
            }

            if (tbObservaciones.Text.Length > 500)
            {
                ok = false;
                mensaje += "Las observaciones no pueden superar los 500 caracteres.";
            }
            
            if(!ok)
            {
                MessageBox.Show(mensaje);
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
            if (ComprobarCampos())
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
