using Biblioteca.Models.Filters;

namespace Biblioteca.Models.ViewModels
{
    public class MembersIndexViewModel
    {
        public PaginatedList<Member> Members { get; set; }
        public MembersFilters Filters { get; set; }
    }
}
