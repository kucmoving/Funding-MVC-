using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Funding_MVC_.Configurations.entities
{
    public class UserRoleSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "1371dd8f-2987-4f4e-a373-e97dec6a044b",
                    UserId = "e371dd8f-2987-4f4e-a373-e97dec6a044b"
                },
                new IdentityUserRole<string>
                {
                    RoleId = "zb8154b2-e26e-48a0-9168-7d1e63b53293",
                    UserId = "ab8154b2-e26e-48a0-9168-7d1e63b53293"
                }
            );
        }
    }
}