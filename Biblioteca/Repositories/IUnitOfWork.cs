using Biblioteca.Models;

namespace Biblioteca.Repositories
{
    public interface IUnitOfWork : IDisposable
    {
        Task Save();
        IGenericRepository<Book> Books { get; }
        IGenericRepository<Member> Members{ get; }
        IGenericRepository<Borrowing> Borrowings { get; }
    }
}
