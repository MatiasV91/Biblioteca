using Biblioteca.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Biblioteca.Data.SeedData
{
    public class BorrowingSeed : IEntityTypeConfiguration<Borrowing>
    {
        public void Configure(EntityTypeBuilder<Borrowing> builder)
        {
            builder.HasData(
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
                }
                );
        }
    }
}
