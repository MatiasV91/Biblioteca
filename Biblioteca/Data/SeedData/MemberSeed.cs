using Biblioteca.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Biblioteca.Data.SeedData
{
    public class MemberSeed : IEntityTypeConfiguration<Member>
    {
        public void Configure(EntityTypeBuilder<Member> builder)
        {
            builder.HasData(
            new Member
            {
                Id = 1,
                FirstName = "Paul ",
                LastName = "Jordan",
                Phone = "415-402-9948",
                Address = "1789 Roosevelt Street"
            }, new Member
            {
                Id = 2,
                FirstName = "Bennie",
                LastName = "Berg",
                Phone = "740-395-3860",
                Address = "3573 Robinson Lane"
            },
            new Member
            {
                Id = 3,
                FirstName = "Deborah",
                LastName = "Carroll",
                Phone = "503-756-1738",
                Address = "227 Illinois Avenue"
            },
            new Member
            {
                Id = 4,
                FirstName = "Clayton",
                LastName = "Charney",
                Phone = "231-912-3291",
                Address = "2519 Owen Lane"
            },
            new Member
            {
                Id = 5,
                FirstName = "Norman",
                LastName = "Grant",
                Phone = "907-592-5611",
                Address = "725 Jerry Toth Drive"
            },
            new Member
            {
                Id = 6,
                FirstName = "Carlos",
                LastName = "Showman",
                Phone = "260-301-1055",
                Address = "3685 Cessna Drive"
            },
            new Member
            {
                Id = 7,
                FirstName = "Michael",
                LastName = "Lombard",
                Phone = "916-731-0951",
                Address = "555 Timber Ridge Road"
            },
            new Member
            {
                Id = 8,
                FirstName = "Leticia",
                LastName = "Martin",
                Phone = "847-582-3103",
                Address = "2613 Thomas Street"
            },
            new Member
            {
                Id = 9,
                FirstName = "Kathy",
                LastName = "Murphy",
                Phone = "4332 Duffy Street",
                Address = "219-788-5848"
            },
            new Member
            {
                Id = 10,
                FirstName = "Helen",
                LastName = "Navarro",
                Phone = "510-526-9981",
                Address = "3608 Lindale Avenue"
            },
            new Member
            {
                Id = 11,
                FirstName = "Jordon",
                LastName = "Lopez",
                Phone = "860-296-3684",
                Address = "13 Hart Street"
            },
            new Member
            {
                Id = 12,
                FirstName = "Frances",
                LastName = "Drew",
                Phone = "303-235-2505",
                Address = "4615 Logan Lane"
            },
            new Member
            {
                Id = 13,
                FirstName = "Christian",
                LastName = "Arvidson",
                Phone = "408-460-0134",
                Address = "3318 Delaware Avenue"
            },
            new Member
            {
                Id = 14,
                FirstName = "Helen",
                LastName = "Branch",
                Phone = "510-390-5862",
                Address = "299 Pretty View Lane"
            },
            new Member
            {
                Id = 15,
                FirstName = "Robert",
                LastName = "Reep",
                Phone = "561-201-7735",
                Address = "4798 County Line Road"
            },
            new Member
            {
                Id = 16,
                FirstName = "Carolyn",
                LastName = "Ferrell",
                Phone = "704-303-7415",
                Address = "4908 Broadcast Drive"
            },
            new Member
            {
                Id = 17,
                FirstName = "Barbara",
                LastName = "Fischer",
                Phone = "561-601-3217",
                Address = "1298 Star Trek Drive"
            },
            new Member
            {
                Id = 18,
                FirstName = "James",
                LastName = "Mallory",
                Phone = "615-214-7742",
                Address = "3708 Frum Street"
            },
            new Member
            {
                Id = 19,
                FirstName = "James",
                LastName = "Brewster",
                Phone = "714-616-6653",
                Address = "4553 Green Avenue"
            },
            new Member
            {
                Id = 20,
                FirstName = "Andrew",
                LastName = "Nagy",
                Phone = "916-814-4101",
                Address = "2255 Woodland Terrace"
            },
            new Member
            {
                Id = 21,
                FirstName = "Jane",
                LastName = "Santacruz",
                Phone = "408-332-9460",
                Address = "1146 Brookview Drive"
            });
        }
    }
}
