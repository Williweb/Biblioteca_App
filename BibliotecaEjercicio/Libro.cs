using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BibliotecaEjercicio
{
    public class Libro:EntidadBiblioteca
    {
        public string Autor { get; set; }
        public string ISBN { get; set; }
        public int AnioPublicacion { get; set; }
        public string Editorial { get; set; }
        public int CantidadDisponible { get; set; }
        public int VecesPrestado { get; set; } = 0;
        public Libro()
        {
            // Constructor por defecto
        }

        public Libro(int id, string nombre, string autor, string isbn, int anio, string editorial, int cantidad)
        {
            Id = id;
            Nombre = nombre;
            Autor = autor;
            ISBN = isbn;
            AnioPublicacion = anio;
            Editorial = editorial;
            CantidadDisponible = cantidad;
        }
        public override string ObtenerInformacion()
        {
            return $"{Nombre} por {Autor} ({Editorial}, {AnioPublicacion})";
        }

        public bool Prestar()
        {
            if (CantidadDisponible > 0)
            {
                CantidadDisponible--;
                VecesPrestado++;
                return true;
            }
            return false;
        }

        public void Devolver()
        {
            CantidadDisponible++;
        }
    }
}
