using Biblioteca.Models;
using Biblioteca.Models.Filters;

namespace Biblioteca.Repositories
{
    public interface IMemberRepository : IGenericRepository<Member>
    {
        Task<PaginatedList<Member>> GetFilteredMembers(MembersFilters filters);
    }
}