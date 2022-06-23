using Funding_MVC_.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Funding_MVC_.Configurations.entities
{
    public class SeedUserConfiguration : IEntityTypeConfiguration<Staff>
    {
        public void Configure(EntityTypeBuilder<Staff> builder)
        {
            var hasher = new PasswordHasher<Staff>();
            builder.HasData(
                new Staff
                {
                    Id = "e371dd8f-2987-4f4e-a373-e97dec6a044b",
                    NormalizedEmail = "ADMIN999@ADMIN.COM",
                    Email = "admin999@admin.com",
                    NormalizedUserName = "ADMIN999@ADMIN.COM",
                    UserName = "admin999@admin.com",
                    Name = "iamadmin",
                    Nickname = "Mr. Admin",
                    PasswordHash = hasher.HashPassword(null, "From1995*"),
                    EmailConfirmed = true
                },
                new Staff
                {
                    Id = "ab8154b2-e26e-48a0-9168-7d1e63b53293",
                    NormalizedEmail = "USER999@STAFF.COM",
                    Email = "user999@staff.com",
                    NormalizedUserName = "USER999@STAFF.COM",
                    UserName = "user999@staff.com",
                    Name = "iamuser",
                    Nickname = "Mr.user",
                    PasswordHash = hasher.HashPassword(null, "From1995*"),
                    EmailConfirmed = true
                }
                );
        }
    }

}