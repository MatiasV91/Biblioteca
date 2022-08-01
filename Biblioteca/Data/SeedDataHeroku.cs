using Biblioteca.Models;
using Microsoft.AspNetCore.Identity;

namespace Biblioteca.Data
{
    public static class SeedDataHeroku
    {
        private const string _adminUser = "admin@library.com";
        private const string _adminPassword = "P@ssword1";
        public async static void PopulateDataBase(IApplicationBuilder app)
        {
            ApplicationDbContext context = app.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<ApplicationDbContext>();
            if (!context.Members.Any())
            {
                context.Members.AddRange(
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
                context.Books.AddRange(
                     new Book
                     {
                         Id = 1,
                         Title = "1984",
                         Author = "George Orwell",
                         CopiesAvailable = 5,
                         ISBN = "9780451524935"
                     }, new Book
                     {
                         Id = 2,
                         Title = "A Brief History of Time",
                         Author = "Stephen Hawking",
                         CopiesAvailable = 1,
                         ISBN = "9780553380163"
                     },
                new Book
                {
                    Id = 3,
                    Title = "Dune",
                    Author = "Frank Herbert",
                    CopiesAvailable = 3,
                    ISBN = "0441013597"
                },
                new Book
                {
                    Id = 4,
                    Title = "Fahrenheit 451",
                    Author = "Ray Bradbury",
                    CopiesAvailable = 7,
                    ISBN = "9781451673319"
                },
                new Book
                {
                    Id = 5,
                    Title = "Fear and Loathing in Las Vegas",
                    Author = "Hunter S. Thompson",
                    CopiesAvailable = 2,
                    ISBN = "9780679785897"
                },
                new Book
                {
                    Id = 6,
                    Title = "The Road",
                    Author = "Cormac McCarthy",
                    CopiesAvailable = 1,
                    ISBN = "9780307387899"
                },
                new Book
                {
                    Id = 7,
                    Title = "Catch-22",
                    Author = "Joseph Heller",
                    CopiesAvailable = 6,
                    ISBN = "1451626657"
                },
                new Book
                {
                    Id = 8,
                    Title = "Harry Potter and the Sorcerer's Stone",
                    Author = "J.K. Rowling",
                    CopiesAvailable = 5,
                    ISBN = "0439708184"
                },
                new Book
                {
                    Id = 9,
                    Title = "Love in the Time of Cholera",
                    Author = "Gabriel Garcia Marquez",
                    CopiesAvailable = 2,
                    ISBN = "0307389731"
                },
                new Book
                {
                    Id = 10,
                    Title = "Slaughterhouse-Five",
                    Author = "Kurt Vonnegut",
                    CopiesAvailable = 1,
                    ISBN = "0812988523"
                },
                new Book
                {
                    Id = 11,
                    Title = "The Catcher in the Rye",
                    Author = "J. D. Salinger",
                    CopiesAvailable = 2,
                    ISBN = "9780316769174"
                },
                new Book
                {
                    Id = 12,
                    Title = "The Hunger Games",
                    Author = "Suzanne Collins",
                    CopiesAvailable = 3,
                    ISBN = "9780439023528"
                },
                new Book
                {
                    Id = 13,
                    Title = "The Lord Of The Rings",
                    Author = "J.R.R. Tolkien",
                    CopiesAvailable = 5,
                    ISBN = "9780544003415"
                },
                new Book
                {
                    Id = 14,
                    Title = "The Shining",
                    Author = "Stephen King",
                    CopiesAvailable = 2,
                    ISBN = "0307743659"
                },
                new Book
                {
                    Id = 15,
                    Title = "The Stranger",
                    Author = "Albert Camus",
                    CopiesAvailable = 1,
                    ISBN = "9780679720201"
                },
                new Book
                {
                    Id = 16,
                    Title = "To Kill a Mockingbird",
                    Author = "Harper Lee ",
                    CopiesAvailable = 2,
                    ISBN = "0446310786"
                },
                new Book
                {
                    Id = 17,
                    Title = "The Alchemist",
                    Author = "Paulo Coelho",
                    CopiesAvailable = 4,
                    ISBN = "0062315005"
                },
                new Book
                {
                    Id = 18,
                    Title = "Lord of the Flies",
                    Author = "William Golding",
                    CopiesAvailable = 6,
                    ISBN = "0399501487"
                },
                new Book
                {
                    Id = 19,
                    Title = "Animal Farm",
                    Author = "George Orwell",
                    CopiesAvailable = 1,
                    ISBN = "9780451526342"
                },
                new Book
                {
                    Id = 20,
                    Title = "The Art of War",
                    Author = "Sun Tzu",
                    CopiesAvailable = 2,
                    ISBN = "1599869772"
                },
                new Book
                {
                    Id = 21,
                    Title = "A Game of Thrones",
                    Author = "George R. R. Martin",
                    CopiesAvailable = 1,
                    ISBN = "9780553593716"
                });

                context.SaveChanges();

                context.Borrowings.AddRange(
                     new Borrowing
                     {
                         Id = 1,
                         AmountOfDays = 7,
                         BookId = 1,
                         MemberId = 1,
                         DateBorrowed = DateTime.Parse("7/1/2022"),
                         DateReturned = DateTime.Parse("7/7/2022"),
                         FinePay = 0
                     },
                    new Borrowing
                    {
                        Id = 2,
                        AmountOfDays = 7,
                        BookId = 3,
                        MemberId = 1,
                        DateBorrowed = DateTime.Parse("7/1/2022"),
                        DateReturned = DateTime.Parse("7/7/2022"),
                        FinePay = 0
                    },
                    new Borrowing
                    {
                        Id = 3,
                        AmountOfDays = 7,
                        BookId = 14,
                        MemberId = 1,
                        DateBorrowed = DateTime.Parse("8/1/2022")
                    });


                UserManager<IdentityUser> userManager = app.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<UserManager<IdentityUser>>();
                IdentityUser user = await userManager.FindByEmailAsync(_adminUser);
                if (user == null)
                {
                    user = new IdentityUser(_adminUser);
                    user.Email = _adminUser;
                    await userManager.CreateAsync(user, _adminPassword);
                }

                context.SaveChanges();
            }
        }
    }
}
