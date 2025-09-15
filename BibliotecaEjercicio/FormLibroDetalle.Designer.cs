namespace BibliotecaEjercicio
{
    partial class FormLibroDetalle
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
            txtNombre = new TextBox();
            txtAutor = new TextBox();
            txtISBN = new TextBox();
            txtEditorial = new TextBox();
            numAnio = new NumericUpDown();
            numCantidad = new NumericUpDown();
            btnAceptar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)numAnio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numCantidad).BeginInit();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(239, 47);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(150, 27);
            txtNombre.TabIndex = 0;
            // 
            // txtAutor
            // 
            txtAutor.Location = new Point(239, 89);
            txtAutor.Name = "txtAutor";
            txtAutor.Size = new Size(150, 27);
            txtAutor.TabIndex = 1;
            // 
            // txtISBN
            // 
            txtISBN.Location = new Point(239, 138);
            txtISBN.Name = "txtISBN";
            txtISBN.Size = new Size(150, 27);
            txtISBN.TabIndex = 2;
            // 
            // txtEditorial
            // 
            txtEditorial.Location = new Point(239, 236);
            txtEditorial.Name = "txtEditorial";
            txtEditorial.Size = new Size(150, 27);
            txtEditorial.TabIndex = 4;
            // 
            // numAnio
            // 
            numAnio.Location = new Point(239, 183);
            numAnio.Maximum = new decimal(new int[] { 2025, 0, 0, 0 });
            numAnio.Name = "numAnio";
            numAnio.Size = new Size(150, 27);
            numAnio.TabIndex = 5;
            // 
            // numCantidad
            // 
            numCantidad.Location = new Point(239, 285);
            numCantidad.Name = "numCantidad";
            numCantidad.Size = new Size(150, 27);
            numCantidad.TabIndex = 6;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(160, 358);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(117, 41);
            btnAceptar.TabIndex = 7;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(76, 50);
            label1.Name = "label1";
            label1.Size = new Size(127, 20);
            label1.TabIndex = 8;
            label1.Text = "Nombre del libro:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(76, 92);
            label2.Name = "label2";
            label2.Size = new Size(109, 20);
            label2.TabIndex = 9;
            label2.Text = "Autor del libro:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(76, 141);
            label3.Name = "label3";
            label3.Size = new Size(41, 20);
            label3.TabIndex = 10;
            label3.Text = "ISBN";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(76, 190);
            label4.Name = "label4";
            label4.Size = new Size(145, 20);
            label4.TabIndex = 11;
            label4.Text = "Año de publicacion: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(76, 239);
            label5.Name = "label5";
            label5.Size = new Size(65, 20);
            label5.TabIndex = 12;
            label5.Text = "Editorial";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(76, 287);
            label6.Name = "label6";
            label6.Size = new Size(69, 20);
            label6.TabIndex = 13;
            label6.Text = "Cantidad";
            // 
            // FormLibroDetalle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(472, 450);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnAceptar);
            Controls.Add(numCantidad);
            Controls.Add(numAnio);
            Controls.Add(txtEditorial);
            Controls.Add(txtISBN);
            Controls.Add(txtAutor);
            Controls.Add(txtNombre);
            Name = "FormLibroDetalle";
            Text = "FormLibroDetalle";
            ((System.ComponentModel.ISupportInitialize)numAnio).EndInit();
            ((System.ComponentModel.ISupportInitialize)numCantidad).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private TextBox txtAutor;
        private TextBox txtISBN;
        private TextBox txtEditorial;
        private NumericUpDown numAnio;
        private NumericUpDown numCantidad;
        private Button btnAceptar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}