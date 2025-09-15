using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaEjercicio
{
    public class Biblioteca
    {
        private List<Libro> libros;
        private List<Usuario> usuarios;
        private List<Prestamo> prestamos;
        private int proximoIdLibro;
        private int proximoIdUsuario;
        private int proximoIdPrestamo;

        public Biblioteca()
        {
            libros = new List<Libro>();
            usuarios = new List<Usuario>();
            prestamos = new List<Prestamo>();
            proximoIdLibro = 1;
            proximoIdUsuario = 1;
            proximoIdPrestamo = 1;

            // Datos de ejemplo
            CargarDatosEjemplo();
        }

        private void CargarDatosEjemplo()
        {
            // Agregar  libros de ejemplo
            AgregarLibro(new Libro(proximoIdLibro++, "El Principito", "Saint-Exupery", "978-8437604947", 1943, "Francia", 5));
            AgregarLibro(new Libro(proximoIdLibro++, "1984", "George Orwell", "978-0451524935", 1949, "Secker & Warburg", 3));
            AgregarLibro(new Libro(proximoIdLibro++, "El Señor de Los anillos", "J R R Tolkien", "978-8424119301", 1977, "Francisco de Robles", 2));

            // Agregar algunos usuarios de ejemplo
            AgregarUsuario(new Usuario(proximoIdUsuario++, "William", "Montano", "willi_eduards@gmail.com", "77861040"));
            AgregarUsuario(new Usuario(proximoIdUsuario++, "karens", "Medrano", "maria@email.com", "555-5678"));
        }

        // CRUD para Libros
        public void AgregarLibro(Libro libro)
        {
            libros.Add(libro);
        }

        public bool EliminarLibro(int id)
        {
            var libro = libros.FirstOrDefault(l => l.Id == id);
            if (libro != null)
            {
                // Verificar si el libro está prestado
                if (prestamos.Any(p => p.LibroId == id && !p.Devuelto))
                {
                    return false; // No se puede eliminar un libro prestado
                }
                libros.Remove(libro);
                return true;
            }
            return false;
        }

        public Libro ObtenerLibro(int id)
        {
            return libros.FirstOrDefault(l => l.Id == id);
        }

        public List<Libro> ObtenerTodosLibros()
        {
            return libros.OrderBy(l => l.Nombre).ToList();
        }

        public List<Libro> BuscarLibros(string criterio)
        {
            return libros.Where(l =>
                l.Nombre.Contains(criterio, StringComparison.OrdinalIgnoreCase) ||
                l.Autor.Contains(criterio, StringComparison.OrdinalIgnoreCase) ||
                l.ISBN.Contains(criterio) ||
                l.Editorial.Contains(criterio, StringComparison.OrdinalIgnoreCase))
                .ToList();
        }

        // CRUD para Usuarios
        public void AgregarUsuario(Usuario usuario)
        {
            usuarios.Add(usuario);
        }

        public bool EliminarUsuario(int id)
        {
            var usuario = usuarios.FirstOrDefault(u => u.Id == id);
            if (usuario != null)
            {
                // Verificar si el usuario tiene préstamos activos
                if (prestamos.Any(p => p.UsuarioId == id && !p.Devuelto))
                {
                    return false; // No se puede eliminar un usuario con préstamos activos
                }
                usuarios.Remove(usuario);
                return true;
            }
            return false;
        }

        public Usuario ObtenerUsuario(int id)
        {
            return usuarios.FirstOrDefault(u => u.Id == id);
        }

        public List<Usuario> ObtenerTodosUsuarios()
        {
            return usuarios.OrderBy(u => u.NombreCompleto).ToList();
        }

        // Gestión de Préstamos
        public bool RealizarPrestamo(int libroId, int usuarioId)
        {
            var libro = ObtenerLibro(libroId);
            var usuario = ObtenerUsuario(usuarioId);

            if (libro == null || usuario == null)
                return false;

            if (libro.CantidadDisponible <= 0)
                return false;

            if (!usuario.PuedePrestar())
                return false;

            if (libro.Prestar())
            {
                usuario.IncrementarPrestamos();
                var prestamo = new Prestamo(proximoIdPrestamo++, libroId, usuarioId);
                prestamos.Add(prestamo);
                return true;
            }

            return false;
        }

        public bool DevolverPrestamo(int prestamoId)
        {
            var prestamo = prestamos.FirstOrDefault(p => p.Id == prestamoId);
            if (prestamo != null && !prestamo.Devuelto)
            {
                var libro = ObtenerLibro(prestamo.LibroId);
                var usuario = ObtenerUsuario(prestamo.UsuarioId);

                if (libro != null && usuario != null)
                {
                    libro.Devolver();
                    usuario.DecrementarPrestamos();
                    prestamo.MarcarDevuelto();
                    return true;
                }
            }
            return false;
        }

        public List<Prestamo> ObtenerPrestamosActivos()
        {
            return prestamos.Where(p => !p.Devuelto).ToList();
        }

        public List<Prestamo> ObtenerHistorialPrestamos()
        {
            return prestamos.OrderByDescending(p => p.FechaPrestamo).ToList();
        }

        // Métodos para estadísticas
        public Dictionary<Libro, int> ObtenerLibrosMasPrestados(int topN = 5)
        {
            return prestamos
                .GroupBy(p => p.LibroId)
                .Select(g => new { Libro = ObtenerLibro(g.Key), Count = g.Count() })
                .OrderByDescending(x => x.Count)
                .Take(topN)
                .ToDictionary(x => x.Libro, x => x.Count);
        }

        public Dictionary<Usuario, int> ObtenerUsuariosMasActivos(int topN = 5)
        {
            return prestamos
                .GroupBy(p => p.UsuarioId)
                .Select(g => new { Usuario = ObtenerUsuario(g.Key), Count = g.Count() })
                .OrderByDescending(x => x.Count)
                .Take(topN)
                .ToDictionary(x => x.Usuario, x => x.Count);
        }

        public int ObtenerTotalPrestamosActivos()
        {
            return prestamos.Count(p => !p.Devuelto);
        }

        public int ObtenerTotalPrestamosAtrasados()
        {
            return prestamos.Count(p => p.EstaAtrasado());
        }
    }
}
