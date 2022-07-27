using Biblioteca.Models;
using Biblioteca.Models.Filters;

namespace Biblioteca.Repositories
{
    public interface IBookRepository : IGenericRepository<Book>
    {
        Task<bool> HasUnreturnedBook(int memberId, int bookId);
        Task<PaginatedList<Book>> GetFilteredBooks(BooksFilters filters);
    }
}