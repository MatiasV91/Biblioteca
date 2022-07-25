namespace Biblioteca.Models
{
    public class BorrowViewModel
    {
        public int MemberId { get; set; }
        public List<Book> Books { get; set; }
    }
}
