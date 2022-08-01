using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Biblioteca.Migrations
{
    public partial class dataSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "CopiesAvailable", "ISBN", "Title" },
                values: new object[,]
                {
                    { 1, "George Orwell", 5, "9780451524935", "1984" },
                    { 2, "Stephen Hawking", 1, "9780553380163", "A Brief History of Time" },
                    { 3, "Frank Herbert", 3, "0441013597", "Dune" },
                    { 4, "Ray Bradbury", 7, "9781451673319", "Fahrenheit 451" },
                    { 5, "Hunter S. Thompson", 2, "9780679785897", "Fear and Loathing in Las Vegas" },
                    { 6, "Cormac McCarthy", 1, "9780307387899", "The Road" },
                    { 7, "Joseph Heller", 6, "1451626657", "Catch-22" },
                    { 8, "J.K. Rowling", 5, "0439708184", "Harry Potter and the Sorcerer's Stone" },
                    { 9, "Gabriel Garcia Marquez", 2, "0307389731", "Love in the Time of Cholera" },
                    { 10, "Kurt Vonnegut", 1, "0812988523", "Slaughterhouse-Five" },
                    { 11, "J. D. Salinger", 2, "9780316769174", "The Catcher in the Rye" },
                    { 12, "Suzanne Collins", 3, "9780439023528", "The Hunger Games" },
                    { 13, "J.R.R. Tolkien", 5, "9780544003415", "The Lord Of The Rings" },
                    { 14, "Stephen King", 2, "0307743659", "The Shining" },
                    { 15, "Albert Camus", 1, "9780679720201", "The Stranger" },
                    { 16, "Harper Lee ", 2, "0446310786", "To Kill a Mockingbird" },
                    { 17, "Paulo Coelho", 4, "0062315005", "The Alchemist" },
                    { 18, "William Golding", 6, "0399501487", "Lord of the Flies" },
                    { 19, "George Orwell", 1, "9780451526342", "Animal Farm" },
                    { 20, "Sun Tzu", 2, "1599869772", "The Art of War" },
                    { 21, "George R. R. Martin", 1, "9780553593716", "A Game of Thrones" }
                });

            migrationBuilder.InsertData(
                table: "Members",
                columns: new[] { "Id", "Address", "FirstName", "LastName", "Phone" },
                values: new object[,]
                {
                    { 1, "1789 Roosevelt Street", "Paul ", "Jordan", "415-402-9948" },
                    { 2, "3573 Robinson Lane", "Bennie", "Berg", "740-395-3860" },
                    { 3, "227 Illinois Avenue", "Deborah", "Carroll", "503-756-1738" },
                    { 4, "2519 Owen Lane", "Clayton", "Charney", "231-912-3291" },
                    { 5, "725 Jerry Toth Drive", "Norman", "Grant", "907-592-5611" },
                    { 6, "3685 Cessna Drive", "Carlos", "Showman", "260-301-1055" },
                    { 7, "555 Timber Ridge Road", "Michael", "Lombard", "916-731-0951" },
                    { 8, "2613 Thomas Street", "Leticia", "Martin", "847-582-3103" },
                    { 9, "219-788-5848", "Kathy", "Murphy", "4332 Duffy Street" },
                    { 10, "3608 Lindale Avenue", "Helen", "Navarro", "510-526-9981" },
                    { 11, "13 Hart Street", "Jordon", "Lopez", "860-296-3684" },
                    { 12, "4615 Logan Lane", "Frances", "Drew", "303-235-2505" },
                    { 13, "3318 Delaware Avenue", "Christian", "Arvidson", "408-460-0134" },
                    { 14, "299 Pretty View Lane", "Helen", "Branch", "510-390-5862" },
                    { 15, "4798 County Line Road", "Robert", "Reep", "561-201-7735" },
                    { 16, "4908 Broadcast Drive", "Carolyn", "Ferrell", "704-303-7415" },
                    { 17, "1298 Star Trek Drive", "Barbara", "Fischer", "561-601-3217" },
                    { 18, "3708 Frum Street", "James", "Mallory", "615-214-7742" },
                    { 19, "4553 Green Avenue", "James", "Brewster", "714-616-6653" },
                    { 20, "2255 Woodland Terrace", "Andrew", "Nagy", "916-814-4101" },
                    { 21, "1146 Brookview Drive", "Jane", "Santacruz", "408-332-9460" }
                });

            migrationBuilder.InsertData(
                table: "Borrowings",
                columns: new[] { "Id", "AmountOfDays", "BookId", "DateBorrowed", "DateReturned", "FinePay", "MemberId" },
                values: new object[] { 1, 7, 1, new DateTime(2022, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 1 });

            migrationBuilder.InsertData(
                table: "Borrowings",
                columns: new[] { "Id", "AmountOfDays", "BookId", "DateBorrowed", "DateReturned", "FinePay", "MemberId" },
                values: new object[] { 2, 7, 3, new DateTime(2022, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 1 });

            migrationBuilder.InsertData(
                table: "Borrowings",
                columns: new[] { "Id", "AmountOfDays", "BookId", "DateBorrowed", "DateReturned", "FinePay", "MemberId" },
                values: new object[] { 3, 7, 1, new DateTime(2022, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0m, 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
