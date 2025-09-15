using System;
using System.Collections.Generic;
using BibliotecaApp.Models;

namespace BibliotecaApp.Repository
{
    public class LibraryRepository
    {
        public List<Book> Books { get; set; } = new List<Book>();
        public List<User> Users { get; set; } = new List<User>();
        public List<Loan> Loans { get; set; } = new List<Loan>();

        public void AddBook(Book book) => Books.Add(book);
        public void RemoveBook(Guid id) => Books.RemoveAll(b => b.Id == id);

        public void AddUser(User user) => Users.Add(user);
        public void RemoveUser(Guid id) => Users.RemoveAll(u => u.Id == id);

        public void AddLoan(Loan loan) => Loans.Add(loan);
    }
}