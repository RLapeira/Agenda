using System.Windows.Forms;

namespace Agenda
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gbContacto = new GroupBox();
            dtpFechaNac = new DateTimePicker();
            tbObservaciones = new TextBox();
            tbTelefono = new TextBox();
            tbNombre = new TextBox();
            tbId = new TextBox();
            lbObservaciones = new Label();
            lbTelefono = new Label();
            lbFechaNac = new Label();
            lbNombre = new Label();
            lbId = new Label();
            btmNuevo = new Button();
            btmEliminar = new Button();
            btmModificar = new Button();
            btmGuardar = new Button();
            btmCancelar = new Button();
            mostrarInfo = new DataGridView();
            gbContacto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)mostrarInfo).BeginInit();
            SuspendLayout();
            // 
            // gbContacto
            // 
            gbContacto.Controls.Add(dtpFechaNac);
            gbContacto.Controls.Add(tbObservaciones);
            gbContacto.Controls.Add(tbTelefono);
            gbContacto.Controls.Add(tbNombre);
            gbContacto.Controls.Add(tbId);
            gbContacto.Controls.Add(lbObservaciones);
            gbContacto.Controls.Add(lbTelefono);
            gbContacto.Controls.Add(lbFechaNac);
            gbContacto.Controls.Add(lbNombre);
            gbContacto.Controls.Add(lbId);
            gbContacto.Location = new Point(27, 23);
            gbContacto.Name = "gbContacto";
            gbContacto.Size = new Size(665, 294);
            gbContacto.TabIndex = 0;
            gbContacto.TabStop = false;
            gbContacto.Text = "Contacto:";
            // 
            // dtpFechaNac
            // 
            dtpFechaNac.Enabled = false;
            dtpFechaNac.Format = DateTimePickerFormat.Short;
            dtpFechaNac.Location = new Point(217, 107);
            dtpFechaNac.Name = "dtpFechaNac";
            dtpFechaNac.Size = new Size(150, 31);
            dtpFechaNac.TabIndex = 7;
            // 
            // tbObservaciones
            // 
            tbObservaciones.Enabled = false;
            tbObservaciones.Location = new Point(217, 189);
            tbObservaciones.Multiline = true;
            tbObservaciones.Name = "tbObservaciones";
            tbObservaciones.Size = new Size(284, 76);
            tbObservaciones.TabIndex = 6;
            // 
            // tbTelefono
            // 
            tbTelefono.Enabled = false;
            tbTelefono.Location = new Point(217, 147);
            tbTelefono.Name = "tbTelefono";
            tbTelefono.Size = new Size(150, 31);
            tbTelefono.TabIndex = 5;
            // 
            // tbNombre
            // 
            tbNombre.Enabled = false;
            tbNombre.Location = new Point(217, 68);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(214, 31);
            tbNombre.TabIndex = 4;
            // 
            // tbId
            // 
            tbId.Enabled = false;
            tbId.Location = new Point(217, 30);
            tbId.Name = "tbId";
            tbId.Size = new Size(65, 31);
            tbId.TabIndex = 1;
            // 
            // lbObservaciones
            // 
            lbObservaciones.AutoSize = true;
            lbObservaciones.Location = new Point(19, 189);
            lbObservaciones.Name = "lbObservaciones";
            lbObservaciones.Size = new Size(132, 25);
            lbObservaciones.TabIndex = 3;
            lbObservaciones.Text = "Observaciones:";
            // 
            // lbTelefono
            // 
            lbTelefono.AutoSize = true;
            lbTelefono.Location = new Point(19, 147);
            lbTelefono.Name = "lbTelefono";
            lbTelefono.Size = new Size(83, 25);
            lbTelefono.TabIndex = 2;
            lbTelefono.Text = "Teléfono:";
            // 
            // lbFechaNac
            // 
            lbFechaNac.AutoSize = true;
            lbFechaNac.Location = new Point(19, 107);
            lbFechaNac.Name = "lbFechaNac";
            lbFechaNac.Size = new Size(156, 25);
            lbFechaNac.TabIndex = 1;
            lbFechaNac.Text = "Fecha Nacimiento:";
            // 
            // lbNombre
            // 
            lbNombre.AutoSize = true;
            lbNombre.Location = new Point(19, 68);
            lbNombre.Name = "lbNombre";
            lbNombre.Size = new Size(82, 25);
            lbNombre.TabIndex = 1;
            lbNombre.Text = "Nombre:";
            // 
            // lbId
            // 
            lbId.AutoSize = true;
            lbId.Location = new Point(19, 30);
            lbId.Name = "lbId";
            lbId.Size = new Size(32, 25);
            lbId.TabIndex = 1;
            lbId.Text = "Id:";
            // 
            // btmNuevo
            // 
            btmNuevo.Location = new Point(27, 323);
            btmNuevo.Name = "btmNuevo";
            btmNuevo.Size = new Size(112, 34);
            btmNuevo.TabIndex = 1;
            btmNuevo.Text = "Nuevo";
            btmNuevo.UseVisualStyleBackColor = true;
            btmNuevo.Click += btmNuevo_Click;
            // 
            // btmEliminar
            // 
            btmEliminar.Location = new Point(145, 323);
            btmEliminar.Name = "btmEliminar";
            btmEliminar.Size = new Size(112, 34);
            btmEliminar.TabIndex = 2;
            btmEliminar.Text = "Eliminar";
            btmEliminar.UseVisualStyleBackColor = true;
            // 
            // btmModificar
            // 
            btmModificar.Location = new Point(263, 323);
            btmModificar.Name = "btmModificar";
            btmModificar.Size = new Size(112, 34);
            btmModificar.TabIndex = 3;
            btmModificar.Text = "Modificar";
            btmModificar.UseVisualStyleBackColor = true;
            // 
            // btmGuardar
            // 
            btmGuardar.Enabled = false;
            btmGuardar.Location = new Point(462, 323);
            btmGuardar.Name = "btmGuardar";
            btmGuardar.Size = new Size(112, 34);
            btmGuardar.TabIndex = 4;
            btmGuardar.Text = "Guardar";
            btmGuardar.UseVisualStyleBackColor = true;
            btmGuardar.Click += btmGuardar_Click;
            // 
            // btmCancelar
            // 
            btmCancelar.Enabled = false;
            btmCancelar.Location = new Point(580, 323);
            btmCancelar.Name = "btmCancelar";
            btmCancelar.Size = new Size(112, 34);
            btmCancelar.TabIndex = 5;
            btmCancelar.Text = "Cancelar";
            btmCancelar.UseVisualStyleBackColor = true;
            btmCancelar.Click += btmCancelar_Click;
            // 
            // mostrarInfo
            // 
            mostrarInfo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            mostrarInfo.Location = new Point(27, 376);
            mostrarInfo.MultiSelect = false;
            mostrarInfo.Name = "mostrarInfo";
            mostrarInfo.RowHeadersWidth = 62;
            mostrarInfo.RowTemplate.Height = 33;
            mostrarInfo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            mostrarInfo.Size = new Size(951, 225);
            mostrarInfo.TabIndex = 6;
            mostrarInfo.RowHeaderMouseClick += mostrarInfo_RowHeaderMouseClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1009, 620);
            Controls.Add(mostrarInfo);
            Controls.Add(btmCancelar);
            Controls.Add(btmGuardar);
            Controls.Add(btmModificar);
            Controls.Add(btmEliminar);
            Controls.Add(btmNuevo);
            Controls.Add(gbContacto);
            Name = "Form1";
            Text = "Agenda de Contactos";
            Load += Form1_Load;
            gbContacto.ResumeLayout(false);
            gbContacto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)mostrarInfo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbContacto;

        private Label lbObservaciones;
        private Label lbTelefono;
        private Label lbFechaNac;
        private Label lbNombre;
        private Label lbId;

        private TextBox tbObservaciones;
        private TextBox tbTelefono;
        private TextBox tbNombre;
        private TextBox tbId;

        private DateTimePicker dtpFechaNac;

        private Button btmNuevo;
        private Button btmEliminar;
        private Button btmModificar;
        private Button btmGuardar;
        private Button btmCancelar;

        private DataGridView mostrarInfo;
    }
}
