using Funding_MVC_.Configurations.entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Funding_MVC_.Data
{
    public class ApplicationDbContext : IdentityDbContext<Staff>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new SeedRoleConfiguration());
            builder.ApplyConfiguration(new SeedUserConfiguration());
            builder.ApplyConfiguration(new UserRoleSeedConfiguration());
        }

        public DbSet<FundCategory> FundCategories { get; set; }
        public DbSet<FundAllocation> FundAllocations { get; set; }

    }
}
