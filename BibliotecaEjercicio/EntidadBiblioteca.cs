using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaEjercicio
{
    public abstract class EntidadBiblioteca
    {
        public int Id { get;protected set; }
        public string Nombre { get; set; }
      
        public abstract string ObtenerInformacion();
    }
}
