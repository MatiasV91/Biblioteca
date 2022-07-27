using Biblioteca.Data;
using Biblioteca.Models;
using Biblioteca.Models.Filters;

namespace Biblioteca.Repositories
{
    public class MemberRepository : GenericRepository<Member>, IMemberRepository
    {
        public MemberRepository(ApplicationDbContext context) : base(context)
        {
        }

        public async Task<PaginatedList<Member>> GetFilteredMembers(MembersFilters filters)
        {
            var query = _context.Members.AsQueryable();
            if (!String.IsNullOrEmpty(filters.FirstName))
            {
                query = query.Where(b => b.FirstName.Contains(filters.FirstName));
            }
            if (!String.IsNullOrEmpty(filters.LastName))
            {
                query = query.Where(b => b.LastName.Contains(filters.LastName));
            }
            return await PaginatedList<Member>.CreateAsync(query, filters.CurrentPage, filters.PageSize);
        }
    }

}
