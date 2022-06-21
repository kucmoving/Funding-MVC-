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

        public DbSet<FundCategory> FundCategories { get; set; }
        public DbSet<FundAllocation> FundAllocations { get; set; }

    }
}