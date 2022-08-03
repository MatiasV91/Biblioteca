using Biblioteca.Data;
using Biblioteca.Models;
using Biblioteca.Models.Filters;
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

        public async Task<PaginatedList<Book>> GetFilteredBooks(BooksFilters filters)
        {
            var query = _context.Books.AsQueryable();
            if (!String.IsNullOrEmpty(filters.AuthorSearch))
            {
                query = query.Where(b => b.Author.ToLower().Contains(filters.AuthorSearch.ToLower()));
            }
            if (!String.IsNullOrEmpty(filters.TitleSearch))
            {
                query = query.Where(b => b.Title.ToLower().Contains(filters.TitleSearch.ToLower()));
            }
            if (!String.IsNullOrEmpty(filters.ISBNSearch))
            {
                query = query.Where(b => b.ISBN.ToLower().Contains(filters.ISBNSearch.ToLower()));
            }
            return await PaginatedList<Book>.CreateAsync(query, filters.CurrentPage, filters.PageSize);
        }
    }
}
