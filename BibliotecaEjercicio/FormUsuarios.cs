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

    public partial class FormUsuarios : Form
    {
        public string Nombre => txtNombre.Text;
        public string Apellido => txtApellido.Text;
        public string Telefono => txtTelefono.Text;
        public string Email => txtEmail.Text;

        public FormUsuarios()
        {
            InitializeComponent();
        }
        public FormUsuarios(Usuario usuario) : this()
        {
            txtNombre.Text = usuario.Nombre;
            txtApellido.Text = usuario.Apellido;
            txtEmail.Text = usuario.Email;
            txtTelefono.Text = usuario.Telefono;
        }
        private bool ValidarDatos()
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("El nombre del usuario es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtTelefono.Text))
            {
                MessageBox.Show("El telefono del usuario es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtApellido.Text))
            {
                MessageBox.Show("El apellido del usuario es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }

}
