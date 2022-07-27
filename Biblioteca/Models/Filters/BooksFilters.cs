namespace Biblioteca.Models.Filters
{
    public class BooksFilters : PageFilter
    {
        public string TitleSearch { get; set; }
        public string AuthorSearch { get; set; }
        public string ISBNSearch { get; set; }
    }
}
