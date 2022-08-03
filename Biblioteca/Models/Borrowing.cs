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
        [Display(Name = "Date Borrowed")]
        public DateTime DateBorrowed { get; set; }
        [Display(Name = "Date Returned")]
        public DateTime? DateReturned { get; set; }
        [Range(1,60,ErrorMessage ="Must Be Between 1 and 60 days")]
        [Display(Name = "Amount Of Days Borrowed")]
        public int AmountOfDays { get; set; }
        [Display(Name = "Late Fine")]
        public decimal FinePay { get; set; }

    }
}
