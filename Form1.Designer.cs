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

            lbObservaciones = new Label();
            lbTelefono = new Label();
            lbFechaNac = new Label();
            lbNombre = new Label();
            lbId = new Label();

            tbId = new TextBox();
            tbNombre = new TextBox();
            tbTelefono = new TextBox();
            tbObservaciones = new TextBox();

            gbContacto.SuspendLayout();
            SuspendLayout();
            // 
            // gbContacto
            // 
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
            // lbObservaciones
            // 
            lbObservaciones.AutoSize = true;
            lbObservaciones.Location = new Point(19, 193);
            lbObservaciones.Name = "lbObservaciones";
            lbObservaciones.Size = new Size(132, 25);
            lbObservaciones.TabIndex = 3;
            lbObservaciones.Text = "Observaciones:";
            // 
            // lbTelefono
            // 
            lbTelefono.AutoSize = true;
            lbTelefono.Location = new Point(19, 151);
            lbTelefono.Name = "lbTelefono";
            lbTelefono.Size = new Size(83, 25);
            lbTelefono.TabIndex = 2;
            lbTelefono.Text = "Teléfono:";
            // 
            // lbFechaNac
            // 
            lbFechaNac.AutoSize = true;
            lbFechaNac.Location = new Point(19, 105);
            lbFechaNac.Name = "lbFechaNac";
            lbFechaNac.Size = new Size(156, 25);
            lbFechaNac.TabIndex = 1;
            lbFechaNac.Text = "Fecha Nacimiento:";
            // 
            // lbNombre
            // 
            lbNombre.AutoSize = true;
            lbNombre.Location = new Point(19, 67);
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
            // tbId
            // 
            tbId.Location = new Point(217, 30);
            tbId.Name = "tbId";
            tbId.Size = new Size(65, 31);
            tbId.TabIndex = 1;
            // 
            // tbNombre
            // 
            tbNombre.Location = new Point(217, 67);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(214, 31);
            tbNombre.TabIndex = 4;
            // 
            // tbTelefono
            // 
            tbTelefono.Location = new Point(217, 151);
            tbTelefono.Name = "tbTelefono";
            tbTelefono.Size = new Size(150, 31);
            tbTelefono.TabIndex = 5;
            // 
            // tbObservaciones
            // 
            tbObservaciones.Location = new Point(217, 193);
            tbObservaciones.Multiline = true;
            tbObservaciones.Name = "tbObservaciones";
            tbObservaciones.Size = new Size(284, 76);
            tbObservaciones.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1009, 450);
            Controls.Add(gbContacto);
            Name = "Form1";
            Text = "Agenda de Contactos";
            gbContacto.ResumeLayout(false);
            gbContacto.PerformLayout();
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
    }
}
