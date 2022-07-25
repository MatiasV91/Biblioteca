using Biblioteca.Data;
using Biblioteca.Models;
using Microsoft.EntityFrameworkCore;

namespace Biblioteca.Repositories
{
    public class BookRepository : GenericRepository<Book>, IBookRepository
    {
        public BookRepository(ApplicationDbContext context) : base(context)
        {
        }

        public async Task<bool> HasUnreturnedBook(int memberId,int bookId)
        {
            return await _context.Borrowings.Where(b => b.MemberId == memberId && b.BookId == bookId).AnyAsync(b => b.DateReturned == null);
        }
    }
}
