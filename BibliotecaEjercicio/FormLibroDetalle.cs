using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotecaEjercicio
{
    public partial class FormLibroDetalle : Form
    {
        public string Nombre => txtNombre.Text;
        public string Autor => txtAutor.Text;
        public string ISBN => txtISBN.Text;
        public int AnioPublicacion => (int)numAnio.Value;
        public string Editorial => txtEditorial.Text;
        public int Cantidad => (int)numCantidad.Value;
        public FormLibroDetalle()
        {
            InitializeComponent();
            this.Text = "Agregar Libro";
        }
        public FormLibroDetalle(Libro libro) : this()
        {
            this.Text = "Editar Libro";
            txtNombre.Text = libro.Nombre;
            txtAutor.Text = libro.Autor;
            txtISBN.Text = libro.ISBN;
            numAnio.Value = libro.AnioPublicacion;
            txtEditorial.Text = libro.Editorial;
            numCantidad.Value = libro.CantidadDisponible;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }
        private bool ValidarDatos()
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("El nombre del libro es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtAutor.Text))
            {
                MessageBox.Show("El autor del libro es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
    }
}
