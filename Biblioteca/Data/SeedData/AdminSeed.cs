using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Biblioteca.Data.SeedData
{
    public class AdminSeed : IEntityTypeConfiguration<IdentityUser>
    {
        public void Configure(EntityTypeBuilder<IdentityUser> builder)
        {
            var hasher = new PasswordHasher<IdentityUser>();
            builder.HasData(
                 new IdentityUser
                 {
                     Id = "21361211-21eb-45c7-8e79-4855d4663438",
                     Email = "admin@library.com",
                     NormalizedEmail = "ADMIN@LIBRARY.COM",
                     UserName = "admin@library.com",
                     NormalizedUserName = "ADMIN@LIBRARY.COM",
                     PasswordHash = hasher.HashPassword(null, "P@ssword1")
                 });
        }
    }
}
