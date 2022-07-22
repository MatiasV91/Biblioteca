using Biblioteca.Data;
using Biblioteca.Models;

namespace Biblioteca.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        private IGenericRepository<Book> _books;
        private IGenericRepository<Member> _members;
        private IGenericRepository<Borrowing> _borrowings;

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
        }

        public IGenericRepository<Book> Books => _books ??= new GenericRepository<Book>(_context);
        public IGenericRepository<Member> Members => _members ??= new GenericRepository<Member>(_context);
        public IGenericRepository<Borrowing> Borrowings => _borrowings ??= new GenericRepository<Borrowing>(_context);

        public void Dispose()
        {
            _context.DisposeAsync();
        }

        public async Task Save()
        {
            await _context.SaveChangesAsync();
        }
    }
}
