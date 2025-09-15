namespace BibliotecaEjercicio
{
    partial class FormPrestamo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAceptar = new Button();
            cmbLibro = new ComboBox();
            cmbUsuario = new ComboBox();
            SuspendLayout();
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(125, 85);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(94, 68);
            btnAceptar.TabIndex = 0;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // cmbLibro
            // 
            cmbLibro.FormattingEnabled = true;
            cmbLibro.Location = new Point(12, 12);
            cmbLibro.Name = "cmbLibro";
            cmbLibro.Size = new Size(151, 28);
            cmbLibro.TabIndex = 1;
            // 
            // cmbUsuario
            // 
            cmbUsuario.FormattingEnabled = true;
            cmbUsuario.Location = new Point(183, 12);
            cmbUsuario.Name = "cmbUsuario";
            cmbUsuario.Size = new Size(151, 28);
            cmbUsuario.TabIndex = 2;
            // 
            // FormPrestamo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(355, 191);
            Controls.Add(cmbUsuario);
            Controls.Add(cmbLibro);
            Controls.Add(btnAceptar);
            Name = "FormPrestamo";
            Text = "FormPrestamo";
            ResumeLayout(false);
        }

        #endregion

        private Button btnAceptar;
        private ComboBox cmbLibro;
        private ComboBox cmbUsuario;
    }
}