using Biblioteca.Models.Filters;

namespace Biblioteca.Models.ViewModels
{
    public class BooksIndexViewModel
    {
        public BooksFilters Filters { get; set; }
        public PaginatedList<Book> Books { get; set; }
    }
}
