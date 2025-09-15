using System;

namespace BibliotecaApp.Models
{
    public class Book
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public int Copies { get; set; }
    }
}