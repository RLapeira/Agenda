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
            lbId = new Label();
            lbNombre = new Label();
            lbFechaNac = new Label();
            lbTelefono = new Label();
            lbObservaciones = new Label();
            gbContacto.SuspendLayout();
            SuspendLayout();
            // 
            // gbContacto
            // 
            gbContacto.Controls.Add(lbObservaciones);
            gbContacto.Controls.Add(lbTelefono);
            gbContacto.Controls.Add(lbFechaNac);
            gbContacto.Controls.Add(lbNombre);
            gbContacto.Controls.Add(lbId);
            gbContacto.Location = new Point(27, 23);
            gbContacto.Name = "gbContacto";
            gbContacto.Size = new Size(542, 271);
            gbContacto.TabIndex = 0;
            gbContacto.TabStop = false;
            gbContacto.Text = "Contacto:";
            // 
            // lbId
            // 
            lbId.AutoSize = true;
            lbId.Location = new Point(19, 30);
            lbId.Name = "lbId";
            lbId.Size = new Size(59, 25);
            lbId.TabIndex = 1;
            lbId.Text = "Id:";
            // 
            // lbNombre
            // 
            lbNombre.AutoSize = true;
            lbNombre.Location = new Point(19, 67);
            lbNombre.Name = "lbNombre";
            lbNombre.Size = new Size(59, 25);
            lbNombre.TabIndex = 1;
            lbNombre.Text = "Nombre:";
            // 
            // lbFechaNac
            // 
            lbFechaNac.AutoSize = true;
            lbFechaNac.Location = new Point(19, 105);
            lbFechaNac.Name = "lbFechaNac";
            lbFechaNac.Size = new Size(59, 25);
            lbFechaNac.TabIndex = 1;
            lbFechaNac.Text = "Fecha Nacimiento:";
            // 
            // lbTelefono
            // 
            lbTelefono.AutoSize = true;
            lbTelefono.Location = new Point(19, 141);
            lbTelefono.Name = "lbTelefono";
            lbTelefono.Size = new Size(59, 25);
            lbTelefono.TabIndex = 2;
            lbTelefono.Text = "Teléfono:";
            // 
            // lbObservaciones
            // 
            lbObservaciones.AutoSize = true;
            lbObservaciones.Location = new Point(19, 181);
            lbObservaciones.Name = "lbObservaciones";
            lbObservaciones.Size = new Size(59, 25);
            lbObservaciones.TabIndex = 3;
            lbObservaciones.Text = "Observaciones:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}
