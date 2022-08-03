using System.ComponentModel.DataAnnotations;

namespace Biblioteca.Models
{
    public class Member
    {
        public int Id { get; set; }
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }

        public ICollection<Borrowing>? Borrowings { get; set; }
    }
}
