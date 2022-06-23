using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Funding_MVC_.Configurations.entities
{
    public class SeedRoleConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
                new IdentityRole
                {
                    Id = "1371dd8f-2987-4f4e-a373-e97dec6a044b",
                    Name = "Adminstartor",
                    NormalizedName = "ADMINSTRATOR"
                },
                new IdentityRole
                {
                    Id = "zb8154b2-e26e-48a0-9168-7d1e63b53293",
                    Name = "User",
                    NormalizedName = "USER"
                }
            );
        }
    }
}
