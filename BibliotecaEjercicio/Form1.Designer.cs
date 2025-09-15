namespace BibliotecaEjercicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            dgvLibros = new DataGridView();
            Idn = new DataGridViewTextBoxColumn();
            Nombren = new DataGridViewTextBoxColumn();
            Autorn = new DataGridViewTextBoxColumn();
            ISBNn = new DataGridViewTextBoxColumn();
            AnioPubn = new DataGridViewTextBoxColumn();
            Editorialn = new DataGridViewTextBoxColumn();
            Cantidadn = new DataGridViewTextBoxColumn();
            VecesPrestn = new DataGridViewTextBoxColumn();
            dgvUsuarios = new DataGridView();
            IdU = new DataGridViewTextBoxColumn();
            NombreU = new DataGridViewTextBoxColumn();
            ApellidoU = new DataGridViewTextBoxColumn();
            EmailU = new DataGridViewTextBoxColumn();
            TelefonoU = new DataGridViewTextBoxColumn();
            FechaU = new DataGridViewTextBoxColumn();
            PrestamosU = new DataGridViewTextBoxColumn();
            dgvPrestamos = new DataGridView();
            IdR = new DataGridViewTextBoxColumn();
            NomreR = new DataGridViewTextBoxColumn();
            NombreComR = new DataGridViewTextBoxColumn();
            FechaR = new DataGridViewTextBoxColumn();
            FechaDevR = new DataGridViewTextBoxColumn();
            EstaAR = new DataGridViewTextBoxColumn();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            lblTotalUsuarios = new Label();
            lblTotalLibros = new Label();
            lblPrestamosActivos = new Label();
            lblPrestamosAtrasados = new Label();
            btnAgregarLibro = new Button();
            btnEditarLibro = new Button();
            btnEliminarLibro = new Button();
            tabControl1 = new TabControl();
            tabPage4 = new TabPage();
            tabPage5 = new TabPage();
            EliminarUsuario = new Button();
            btnEditarUsuario = new Button();
            btnAgregarUsuario = new Button();
            tabPage1 = new TabPage();
            btnDevolverPrestamo = new Button();
            btnRealizarPrestamo = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvLibros).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPrestamos).BeginInit();
            tabControl1.SuspendLayout();
            tabPage4.SuspendLayout();
            tabPage5.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dgvLibros
            // 
            dgvLibros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLibros.Columns.AddRange(new DataGridViewColumn[] { Idn, Nombren, Autorn, ISBNn, AnioPubn, Editorialn, Cantidadn, VecesPrestn });
            dgvLibros.Location = new Point(5, 4);
            dgvLibros.Margin = new Padding(3, 2, 3, 2);
            dgvLibros.Name = "dgvLibros";
            dgvLibros.ReadOnly = true;
            dgvLibros.RowHeadersWidth = 51;
            dgvLibros.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLibros.Size = new Size(489, 268);
            dgvLibros.TabIndex = 0;
            // 
            // Idn
            // 
            Idn.HeaderText = "Id";
            Idn.MinimumWidth = 6;
            Idn.Name = "Idn";
            Idn.ReadOnly = true;
            Idn.Width = 125;
            // 
            // Nombren
            // 
            Nombren.HeaderText = "Nombre";
            Nombren.MinimumWidth = 6;
            Nombren.Name = "Nombren";
            Nombren.ReadOnly = true;
            Nombren.Width = 125;
            // 
            // Autorn
            // 
            Autorn.HeaderText = "Autor";
            Autorn.MinimumWidth = 6;
            Autorn.Name = "Autorn";
            Autorn.ReadOnly = true;
            Autorn.Width = 125;
            // 
            // ISBNn
            // 
            ISBNn.HeaderText = "ISBN";
            ISBNn.MinimumWidth = 6;
            ISBNn.Name = "ISBNn";
            ISBNn.ReadOnly = true;
            ISBNn.Width = 125;
            // 
            // AnioPubn
            // 
            AnioPubn.HeaderText = "Fecha Publicacion";
            AnioPubn.MinimumWidth = 6;
            AnioPubn.Name = "AnioPubn";
            AnioPubn.ReadOnly = true;
            AnioPubn.Width = 125;
            // 
            // Editorialn
            // 
            Editorialn.HeaderText = "Editorial";
            Editorialn.MinimumWidth = 6;
            Editorialn.Name = "Editorialn";
            Editorialn.ReadOnly = true;
            Editorialn.Width = 125;
            // 
            // Cantidadn
            // 
            Cantidadn.HeaderText = "Disponibles";
            Cantidadn.MinimumWidth = 6;
            Cantidadn.Name = "Cantidadn";
            Cantidadn.ReadOnly = true;
            Cantidadn.Width = 125;
            // 
            // VecesPrestn
            // 
            VecesPrestn.HeaderText = "Veces Prestado";
            VecesPrestn.MinimumWidth = 6;
            VecesPrestn.Name = "VecesPrestn";
            VecesPrestn.ReadOnly = true;
            VecesPrestn.Width = 125;
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Columns.AddRange(new DataGridViewColumn[] { IdU, NombreU, ApellidoU, EmailU, TelefonoU, FechaU, PrestamosU });
            dgvUsuarios.Location = new Point(5, 4);
            dgvUsuarios.Margin = new Padding(3, 2, 3, 2);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.ReadOnly = true;
            dgvUsuarios.RowHeadersWidth = 51;
            dgvUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsuarios.Size = new Size(481, 268);
            dgvUsuarios.TabIndex = 1;
            // 
            // IdU
            // 
            IdU.HeaderText = "Id";
            IdU.MinimumWidth = 6;
            IdU.Name = "IdU";
            IdU.ReadOnly = true;
            IdU.Width = 125;
            // 
            // NombreU
            // 
            NombreU.HeaderText = "Nombre";
            NombreU.MinimumWidth = 6;
            NombreU.Name = "NombreU";
            NombreU.ReadOnly = true;
            NombreU.Width = 125;
            // 
            // ApellidoU
            // 
            ApellidoU.HeaderText = "Apellido";
            ApellidoU.MinimumWidth = 6;
            ApellidoU.Name = "ApellidoU";
            ApellidoU.ReadOnly = true;
            ApellidoU.Width = 125;
            // 
            // EmailU
            // 
            EmailU.HeaderText = "Email";
            EmailU.MinimumWidth = 6;
            EmailU.Name = "EmailU";
            EmailU.ReadOnly = true;
            EmailU.Width = 125;
            // 
            // TelefonoU
            // 
            TelefonoU.HeaderText = "Telefono";
            TelefonoU.MinimumWidth = 6;
            TelefonoU.Name = "TelefonoU";
            TelefonoU.ReadOnly = true;
            TelefonoU.Width = 125;
            // 
            // FechaU
            // 
            FechaU.HeaderText = "Fecha Registro";
            FechaU.MinimumWidth = 6;
            FechaU.Name = "FechaU";
            FechaU.ReadOnly = true;
            FechaU.Width = 125;
            // 
            // PrestamosU
            // 
            PrestamosU.HeaderText = "Prestamos Activos";
            PrestamosU.MinimumWidth = 6;
            PrestamosU.Name = "PrestamosU";
            PrestamosU.ReadOnly = true;
            PrestamosU.Width = 125;
            // 
            // dgvPrestamos
            // 
            dgvPrestamos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPrestamos.Columns.AddRange(new DataGridViewColumn[] { IdR, NomreR, NombreComR, FechaR, FechaDevR, EstaAR });
            dgvPrestamos.Location = new Point(4, 4);
            dgvPrestamos.Margin = new Padding(3, 2, 3, 2);
            dgvPrestamos.Name = "dgvPrestamos";
            dgvPrestamos.ReadOnly = true;
            dgvPrestamos.RowHeadersWidth = 51;
            dgvPrestamos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPrestamos.Size = new Size(500, 272);
            dgvPrestamos.TabIndex = 2;
            // 
            // IdR
            // 
            IdR.HeaderText = "Id";
            IdR.MinimumWidth = 6;
            IdR.Name = "IdR";
            IdR.ReadOnly = true;
            IdR.Width = 125;
            // 
            // NomreR
            // 
            NomreR.HeaderText = "Nombre";
            NomreR.MinimumWidth = 6;
            NomreR.Name = "NomreR";
            NomreR.ReadOnly = true;
            NomreR.Width = 125;
            // 
            // NombreComR
            // 
            NombreComR.HeaderText = "Nombre Completo";
            NombreComR.MinimumWidth = 6;
            NombreComR.Name = "NombreComR";
            NombreComR.ReadOnly = true;
            NombreComR.Width = 125;
            // 
            // FechaR
            // 
            FechaR.HeaderText = "Fecha Prestamo";
            FechaR.MinimumWidth = 6;
            FechaR.Name = "FechaR";
            FechaR.ReadOnly = true;
            FechaR.Width = 125;
            // 
            // FechaDevR
            // 
            FechaDevR.HeaderText = "Fecha Devolucion";
            FechaDevR.MinimumWidth = 6;
            FechaDevR.Name = "FechaDevR";
            FechaDevR.ReadOnly = true;
            FechaDevR.Width = 125;
            // 
            // EstaAR
            // 
            EstaAR.HeaderText = "Estado Atrasado";
            EstaAR.MinimumWidth = 6;
            EstaAR.Name = "EstaAR";
            EstaAR.ReadOnly = true;
            EstaAR.Width = 125;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 14);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 3;
            label1.Text = "Libros:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 44);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 4;
            label2.Text = "Usuarios:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(164, 14);
            label3.Name = "label3";
            label3.Size = new Size(107, 15);
            label3.TabIndex = 5;
            label3.Text = "Prestamos Activos:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(164, 44);
            label4.Name = "label4";
            label4.Size = new Size(120, 15);
            label4.TabIndex = 6;
            label4.Text = "Prestamos Atrasados:";
            // 
            // lblTotalUsuarios
            // 
            lblTotalUsuarios.AutoSize = true;
            lblTotalUsuarios.Location = new Point(87, 44);
            lblTotalUsuarios.Name = "lblTotalUsuarios";
            lblTotalUsuarios.Size = new Size(42, 15);
            lblTotalUsuarios.TabIndex = 7;
            lblTotalUsuarios.Text = "Libros:";
            // 
            // lblTotalLibros
            // 
            lblTotalLibros.AutoSize = true;
            lblTotalLibros.Location = new Point(87, 14);
            lblTotalLibros.Name = "lblTotalLibros";
            lblTotalLibros.Size = new Size(42, 15);
            lblTotalLibros.TabIndex = 8;
            lblTotalLibros.Text = "Libros:";
            // 
            // lblPrestamosActivos
            // 
            lblPrestamosActivos.AutoSize = true;
            lblPrestamosActivos.Location = new Point(301, 14);
            lblPrestamosActivos.Name = "lblPrestamosActivos";
            lblPrestamosActivos.Size = new Size(42, 15);
            lblPrestamosActivos.TabIndex = 9;
            lblPrestamosActivos.Text = "Libros:";
            // 
            // lblPrestamosAtrasados
            // 
            lblPrestamosAtrasados.AutoSize = true;
            lblPrestamosAtrasados.Location = new Point(301, 44);
            lblPrestamosAtrasados.Name = "lblPrestamosAtrasados";
            lblPrestamosAtrasados.Size = new Size(42, 15);
            lblPrestamosAtrasados.TabIndex = 10;
            lblPrestamosAtrasados.Text = "Libros:";
            // 
            // btnAgregarLibro
            // 
            btnAgregarLibro.Location = new Point(508, 4);
            btnAgregarLibro.Margin = new Padding(3, 2, 3, 2);
            btnAgregarLibro.Name = "btnAgregarLibro";
            btnAgregarLibro.Size = new Size(82, 49);
            btnAgregarLibro.TabIndex = 11;
            btnAgregarLibro.Text = "Agregar Libro";
            btnAgregarLibro.UseVisualStyleBackColor = true;
            btnAgregarLibro.Click += btnAgregarLibro_Click;
            // 
            // btnEditarLibro
            // 
            btnEditarLibro.Location = new Point(508, 58);
            btnEditarLibro.Margin = new Padding(3, 2, 3, 2);
            btnEditarLibro.Name = "btnEditarLibro";
            btnEditarLibro.Size = new Size(82, 49);
            btnEditarLibro.TabIndex = 12;
            btnEditarLibro.Text = "Editar Libro";
            btnEditarLibro.UseVisualStyleBackColor = true;
            btnEditarLibro.Click += btnEditarLibro_Click;
            // 
            // btnEliminarLibro
            // 
            btnEliminarLibro.Location = new Point(508, 112);
            btnEliminarLibro.Margin = new Padding(3, 2, 3, 2);
            btnEliminarLibro.Name = "btnEliminarLibro";
            btnEliminarLibro.Size = new Size(82, 49);
            btnEliminarLibro.TabIndex = 13;
            btnEliminarLibro.Text = "Eliminar Libro";
            btnEliminarLibro.UseVisualStyleBackColor = true;
            btnEliminarLibro.Click += btnEliminarLibro_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Controls.Add(tabPage5);
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Location = new Point(7, 76);
            tabControl1.Margin = new Padding(3, 2, 3, 2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(603, 302);
            tabControl1.TabIndex = 14;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(btnEditarLibro);
            tabPage4.Controls.Add(btnEliminarLibro);
            tabPage4.Controls.Add(btnAgregarLibro);
            tabPage4.Controls.Add(dgvLibros);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Margin = new Padding(3, 2, 3, 2);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3, 2, 3, 2);
            tabPage4.Size = new Size(595, 274);
            tabPage4.TabIndex = 0;
            tabPage4.Text = "Libros";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            tabPage5.Controls.Add(EliminarUsuario);
            tabPage5.Controls.Add(btnEditarUsuario);
            tabPage5.Controls.Add(btnAgregarUsuario);
            tabPage5.Controls.Add(dgvUsuarios);
            tabPage5.Location = new Point(4, 24);
            tabPage5.Margin = new Padding(3, 2, 3, 2);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(3, 2, 3, 2);
            tabPage5.Size = new Size(595, 274);
            tabPage5.TabIndex = 1;
            tabPage5.Text = "Usuarios";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // EliminarUsuario
            // 
            EliminarUsuario.Location = new Point(508, 114);
            EliminarUsuario.Margin = new Padding(3, 2, 3, 2);
            EliminarUsuario.Name = "EliminarUsuario";
            EliminarUsuario.Size = new Size(82, 50);
            EliminarUsuario.TabIndex = 4;
            EliminarUsuario.Text = "Eliminar Usuario";
            EliminarUsuario.UseVisualStyleBackColor = true;
            EliminarUsuario.Click += EliminarUsuario_Click;
            // 
            // btnEditarUsuario
            // 
            btnEditarUsuario.Location = new Point(508, 59);
            btnEditarUsuario.Margin = new Padding(3, 2, 3, 2);
            btnEditarUsuario.Name = "btnEditarUsuario";
            btnEditarUsuario.Size = new Size(82, 50);
            btnEditarUsuario.TabIndex = 3;
            btnEditarUsuario.Text = "Editar Usario";
            btnEditarUsuario.UseVisualStyleBackColor = true;
            // 
            // btnAgregarUsuario
            // 
            btnAgregarUsuario.Location = new Point(508, 4);
            btnAgregarUsuario.Margin = new Padding(3, 2, 3, 2);
            btnAgregarUsuario.Name = "btnAgregarUsuario";
            btnAgregarUsuario.Size = new Size(82, 50);
            btnAgregarUsuario.TabIndex = 2;
            btnAgregarUsuario.Text = "Agregar Usuario";
            btnAgregarUsuario.UseVisualStyleBackColor = true;
            btnAgregarUsuario.Click += btnAgregarUsuario_Click;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnDevolverPrestamo);
            tabPage1.Controls.Add(btnRealizarPrestamo);
            tabPage1.Controls.Add(dgvPrestamos);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Margin = new Padding(3, 2, 3, 2);
            tabPage1.Name = "tabPage1";
            tabPage1.Size = new Size(595, 274);
            tabPage1.TabIndex = 2;
            tabPage1.Text = "Prestamos";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnDevolverPrestamo
            // 
            btnDevolverPrestamo.Location = new Point(510, 58);
            btnDevolverPrestamo.Margin = new Padding(3, 2, 3, 2);
            btnDevolverPrestamo.Name = "btnDevolverPrestamo";
            btnDevolverPrestamo.Size = new Size(82, 49);
            btnDevolverPrestamo.TabIndex = 4;
            btnDevolverPrestamo.Text = "Devolver Prestamo";
            btnDevolverPrestamo.UseVisualStyleBackColor = true;
            btnDevolverPrestamo.Click += btnDevolverPrestamo_Click;
            // 
            // btnRealizarPrestamo
            // 
            btnRealizarPrestamo.Location = new Point(510, 4);
            btnRealizarPrestamo.Margin = new Padding(3, 2, 3, 2);
            btnRealizarPrestamo.Name = "btnRealizarPrestamo";
            btnRealizarPrestamo.Size = new Size(82, 49);
            btnRealizarPrestamo.TabIndex = 3;
            btnRealizarPrestamo.Text = "Realizar Prestamo";
            btnRealizarPrestamo.UseVisualStyleBackColor = true;
            btnRealizarPrestamo.Click += btnRealizarPrestamo_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(466, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(135, 74);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.CornflowerBlue;
            ClientSize = new Size(616, 382);
            Controls.Add(pictureBox1);
            Controls.Add(tabControl1);
            Controls.Add(lblPrestamosAtrasados);
            Controls.Add(lblPrestamosActivos);
            Controls.Add(lblTotalLibros);
            Controls.Add(lblTotalUsuarios);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvLibros).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPrestamos).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage4.ResumeLayout(false);
            tabPage5.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvLibros;
        private DataGridView dgvUsuarios;
        private DataGridView dgvPrestamos;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label lblTotalUsuarios;
        private Label lblTotalLibros;
        private Label lblPrestamosActivos;
        private Label lblPrestamosAtrasados;
        private DataGridViewTextBoxColumn Idn;
        private DataGridViewTextBoxColumn Nombren;
        private DataGridViewTextBoxColumn Autorn;
        private DataGridViewTextBoxColumn ISBNn;
        private DataGridViewTextBoxColumn AnioPubn;
        private DataGridViewTextBoxColumn Editorialn;
        private DataGridViewTextBoxColumn Cantidadn;
        private DataGridViewTextBoxColumn VecesPrestn;
        private DataGridViewTextBoxColumn IdU;
        private DataGridViewTextBoxColumn NombreU;
        private DataGridViewTextBoxColumn ApellidoU;
        private DataGridViewTextBoxColumn EmailU;
        private DataGridViewTextBoxColumn TelefonoU;
        private DataGridViewTextBoxColumn FechaU;
        private DataGridViewTextBoxColumn PrestamosU;
        private DataGridViewTextBoxColumn IdR;
        private DataGridViewTextBoxColumn NomreR;
        private DataGridViewTextBoxColumn NombreComR;
        private DataGridViewTextBoxColumn FechaR;
        private DataGridViewTextBoxColumn FechaDevR;
        private DataGridViewTextBoxColumn EstaAR;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage1;
        private Button btnAgregarLibro;
        private Button btnEditarLibro;
        private Button btnEliminarLibro;
        private TabControl tabControl1;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private Button btnRealizarPrestamo;
        private Button btnDevolverPrestamo;
        private Button EliminarUsuario;
        private Button btnEditarUsuario;
        private Button btnAgregarUsuario;
        private PictureBox pictureBox1;
    }
}
