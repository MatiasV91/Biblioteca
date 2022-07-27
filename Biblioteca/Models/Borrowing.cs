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
        [Range(1,60,ErrorMessage ="Must Be Between 1 and 60 days")]
        public int AmountOfDays { get; set; }
        public decimal FinePay { get; set; }

    }
}
