using Funding_MVC_.Data;
using Funding_MVC_.Interface;

namespace Funding_MVC_.Repository
{
    public class FundCategoryRepository : GenericRepository<FundCategory>, IFundCategoryRepository
    {
        public FundCategoryRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
