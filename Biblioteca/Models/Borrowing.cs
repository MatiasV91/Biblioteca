using System.ComponentModel.DataAnnotations;

namespace Biblioteca.Models
{
    public class Borrowing
    {
        public int Id { get; set; }
        public int MemberId { get; set; }
        public Member? Member { get; set; }
        public int BookId { get; set; }
        public Book? Book{ get; set; }
        public DateTime DateBorrowed { get; set; }
        public DateTime? DateReturned { get; set; }

        public int AmountOfDays { get; set; }

    }
}
