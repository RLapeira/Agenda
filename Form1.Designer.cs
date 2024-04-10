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
            SuspendLayout();
            // 
            // groupBox1
            // 
            gbContacto.Location = new Point(27, 23);
            gbContacto.Name = "gbContacto";
            gbContacto.Size = new Size(542, 150);
            gbContacto.TabIndex = 0;
            gbContacto.TabStop = false;
            gbContacto.Text = "Contacto:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(gbContacto);
            Name = "Form1";
            Text = "Agenda de Contactos";
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbContacto;
    }
}
