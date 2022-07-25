using Biblioteca.Models;

namespace Biblioteca.Repositories
{
    public interface IBookRepository : IGenericRepository<Book>
    {
        Task<bool> HasUnreturnedBook(int memberId, int bookId);
    }
}