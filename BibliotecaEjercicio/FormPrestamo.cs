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
    public partial class FormPrestamo : Form
    {
        private Biblioteca biblioteca;

        public int LibroId { get; private set; }
        public int UsuarioId { get; private set; }
        public FormPrestamo(Biblioteca bib)
        {
            InitializeComponent();
            biblioteca = bib;
            CargarComboBoxes();
        }
        private void CargarComboBoxes()
        {
            // Cargar libros disponibles
            cmbLibro.DisplayMember = "Nombre";
            cmbLibro.ValueMember = "Id";
            cmbLibro.DataSource = biblioteca.ObtenerTodosLibros().Where(l => l.CantidadDisponible > 0).ToList();

            // Cargar usuarios que pueden prestar
            cmbUsuario.DisplayMember = "NombreCompleto";
            cmbUsuario.ValueMember = "Id";
            cmbUsuario.DataSource = biblioteca.ObtenerTodosUsuarios().Where(u => u.PuedePrestar()).ToList();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (cmbLibro.SelectedValue != null && cmbUsuario.SelectedValue != null)
            {
                LibroId = (int)cmbLibro.SelectedValue;
                UsuarioId = (int)cmbUsuario.SelectedValue;
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Seleccione un libro y un usuario válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

