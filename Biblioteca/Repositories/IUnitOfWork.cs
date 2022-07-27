using Biblioteca.Models;

namespace Biblioteca.Repositories
{
    public interface IUnitOfWork : IDisposable
    {
        Task Save();
        IBookRepository Books { get; }
        IMemberRepository Members { get; }
        IGenericRepository<Borrowing> Borrowings { get; }
    }
}
