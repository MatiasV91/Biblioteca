using Biblioteca.Data;
using Biblioteca.Models;

namespace Biblioteca.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        private IBookRepository _books;
        private IMemberRepository _members;
        private IGenericRepository<Borrowing> _borrowings;

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
        }

        public IBookRepository Books => _books ??= new BookRepository(_context);
        public IMemberRepository Members => _members ??= new MemberRepository(_context);
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
