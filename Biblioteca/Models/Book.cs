namespace Biblioteca.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public bool IsAvailable { get; set; }
        public virtual ICollection<Borrowing>? Borrowings { get; set; }

    }
}
