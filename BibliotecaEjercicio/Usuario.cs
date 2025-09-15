using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaEjercicio
{
    public class Usuario
    {
        public int Id { get; private set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public DateTime FechaRegistro { get; private set; }
        public int PrestamosActivos { get; set; } = 0;

        public Usuario(int id, string nombre, string apellido, string email, string telefono)
        {
            Id = id;
            Nombre = nombre;
            Apellido = apellido;
            Email = email;
            Telefono = telefono;
            FechaRegistro = DateTime.Now;
        }

        public string NombreCompleto => $"{Nombre} {Apellido}";

        public bool PuedePrestar()
        {
            return PrestamosActivos < 3; // Límite de 3 préstamos por usuario
        }

        public void IncrementarPrestamos()
        {
            PrestamosActivos++;
        }

        public void DecrementarPrestamos()
        {
            if (PrestamosActivos > 0) PrestamosActivos--;
        }
    }
}
