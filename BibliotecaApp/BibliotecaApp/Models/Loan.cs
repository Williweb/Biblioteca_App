using System;

namespace BibliotecaApp.Models
{
    public class Loan
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public Guid UserId { get; set; }
        public Guid BookId { get; set; }
        public DateTime LoanDate { get; set; }
        public DateTime? ReturnDate { get; set; }
        public bool Returned { get; set; }
    }
}