using System.ComponentModel.DataAnnotations;

namespace Biblioteca.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        [Display(Name = "Copies Available")]
        public int CopiesAvailable { get; set; }
        public virtual ICollection<Borrowing>? Borrowings { get; set; }

    }
}
