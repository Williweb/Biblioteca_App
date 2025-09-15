using System.Windows.Forms;

namespace BibliotecaEjercicio

{
    public partial class Form1 : Form
    {

        private Biblioteca biblioteca;
        public Form1()
        {
            InitializeComponent();
            biblioteca = new Biblioteca();
            CargarDatos();

        }
        private void CargarDatos()
        {
            CargarLibros();
            CargarUsuarios();
            CargarPrestamos();
            CargarEstadisticas();
        }
        private void CargarLibros()
        {
            dgvLibros.Rows.Clear();
            var libros = biblioteca.ObtenerTodosLibros();

            foreach (var libro in libros)
            {
                dgvLibros.Rows.Add(
                    libro.Id,
                    libro.Nombre,
                    libro.Autor,
                    libro.ISBN,
                    libro.AnioPublicacion,
                    libro.Editorial,
                    libro.CantidadDisponible,
                    libro.VecesPrestado
                );
            }
        }
        private void CargarUsuarios()
        {
            dgvUsuarios.Rows.Clear();
            var usuarios = biblioteca.ObtenerTodosUsuarios();

            foreach (var usuario in usuarios)
            {
                dgvUsuarios.Rows.Add(
                    usuario.Id,
                    usuario.Nombre,
                    usuario.Apellido,
                    usuario.Email,
                    usuario.Telefono,
                    usuario.FechaRegistro.ToShortDateString(),
                    usuario.PrestamosActivos
                );
            }
        }
        private void CargarPrestamos()
        {
            dgvPrestamos.Rows.Clear();
            var prestamos = biblioteca.ObtenerPrestamosActivos();

            foreach (var prestamo in prestamos)
            {
                var libro = biblioteca.ObtenerLibro(prestamo.LibroId);
                var usuario = biblioteca.ObtenerUsuario(prestamo.UsuarioId);

                dgvPrestamos.Rows.Add(
                    prestamo.Id,
                    libro.Nombre,
                    usuario.NombreCompleto,
                    prestamo.FechaPrestamo.ToShortDateString(),
                    prestamo.FechaDevolucionPrevista.ToShortDateString(),
                    prestamo.EstaAtrasado() ? "SÍ" : "NO"
                );
            }
        }
        private void CargarEstadisticas()
        {
            lblTotalLibros.Text = biblioteca.ObtenerTodosLibros().Count.ToString();
            lblTotalUsuarios.Text = biblioteca.ObtenerTodosUsuarios().Count.ToString();
            lblPrestamosActivos.Text = biblioteca.ObtenerTotalPrestamosActivos().ToString();
            lblPrestamosAtrasados.Text = biblioteca.ObtenerTotalPrestamosAtrasados().ToString();

        }

        private void btnAgregarLibro_Click(object sender, EventArgs e)
        {
            using (var form = new FormLibroDetalle())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    var libro = new Libro(
                        0, // ID se asignará automáticamente
                        form.Nombre,
                        form.Autor,
                        form.ISBN,
                        form.AnioPublicacion,
                        form.Editorial,
                        form.Cantidad
                    );

                    biblioteca.AgregarLibro(libro);
                    CargarLibros();
                    MessageBox.Show("Libro agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnEditarLibro_Click(object sender, EventArgs e)
        {
            if (dgvLibros.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un libro para editar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = (int)dgvLibros.SelectedRows[0].Cells[0].Value;
            var libro = biblioteca.ObtenerLibro(id);

            if (libro != null)
            {
                using (var form = new FormLibroDetalle(libro))
                {
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        libro.Nombre = form.Nombre;
                        libro.Autor = form.Autor;
                        libro.ISBN = form.ISBN;
                        libro.AnioPublicacion = form.AnioPublicacion;
                        libro.Editorial = form.Editorial;
                        libro.CantidadDisponible = form.Cantidad;

                        CargarLibros();
                        MessageBox.Show("Libro actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void btnEliminarLibro_Click(object sender, EventArgs e)
        {
            if (dgvLibros.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un libro para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = (int)dgvLibros.SelectedRows[0].Cells[0].Value;

            if (MessageBox.Show("¿Está seguro de eliminar este libro?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (biblioteca.EliminarLibro(id))
                {
                    CargarLibros();
                    MessageBox.Show("Libro eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se puede eliminar el libro porque está prestado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnRealizarPrestamo_Click(object sender, EventArgs e)
        {
            using (var form = new FormPrestamo(biblioteca))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    if (biblioteca.RealizarPrestamo(form.LibroId, form.UsuarioId))
                    {
                        CargarLibros();
                        CargarUsuarios();
                        CargarPrestamos();
                        MessageBox.Show("Préstamo realizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se pudo realizar el préstamo. Verifique la disponibilidad del libro y que el usuario no exceda el límite.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnDevolverPrestamo_Click(object sender, EventArgs e)
        {
            if (dgvPrestamos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un préstamo para devolver.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = (int)dgvPrestamos.SelectedRows[0].Cells[0].Value;

            if (biblioteca.DevolverPrestamo(id))
            {
                CargarLibros();
                CargarUsuarios();
                CargarPrestamos();
                MessageBox.Show("Devolución registrada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se pudo registrar la devolución.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }







        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            using (var form = new FormUsuarios())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    var usuario = new Usuario(
                        0, // ID se asignará automáticamente
                        form.Nombre,
                        form.Apellido,
                        form.Email,
                        form.Telefono

                    );

                    biblioteca.AgregarUsuario(usuario);
                    CargarUsuarios();
                    MessageBox.Show("Libro agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void EliminarUsuario_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un usuario para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = (int)dgvUsuarios.SelectedRows[0].Cells[0].Value;

            if (MessageBox.Show("¿Está seguro de eliminar este Usuario?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (biblioteca.EliminarUsuario(id))
                {
                    CargarUsuarios();
                    MessageBox.Show("Usuario eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se puede eliminar el usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

