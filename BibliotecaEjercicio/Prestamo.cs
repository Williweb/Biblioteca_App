using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaEjercicio
{
    public class Prestamo
    {
        public int Id { get; private set; }
        public int LibroId { get; set; }
        public int UsuarioId { get; set; }
        public DateTime FechaPrestamo { get; set; }
        public DateTime FechaDevolucionPrevista { get; set; }
        public DateTime? FechaDevolucionReal { get; set; }
        public bool Devuelto => FechaDevolucionReal.HasValue;

        public Prestamo(int id, int libroId, int usuarioId)
        {
            Id = id;
            LibroId = libroId;
            UsuarioId = usuarioId;
            FechaPrestamo = DateTime.Now;
            FechaDevolucionPrevista = DateTime.Now.AddDays(14); // 2 semanas para devolver
        }

        public void MarcarDevuelto()
        {
            FechaDevolucionReal = DateTime.Now;
        }

        public bool EstaAtrasado()
        {
            return !Devuelto && DateTime.Now > FechaDevolucionPrevista;
        }

        public int DiasAtraso()
        {
            if (!Devuelto && EstaAtrasado())
            {
                return (DateTime.Now - FechaDevolucionPrevista).Days;
            }
            return 0;
        }
    }
}
