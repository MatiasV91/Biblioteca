using Biblioteca.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Biblioteca.Data.SeedData
{
    public class BookSeed : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasData(
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
        }
    }
}
