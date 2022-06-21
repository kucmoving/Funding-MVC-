using System.ComponentModel.DataAnnotations.Schema;

namespace Funding_MVC_.Data
{
    public class FundAllocation : BaseEntity
    {
        public int FundAmount { get; set; }

        /// one to many
       
        [ForeignKey("FundCategoryId")]
        public FundCategory FundCategory { get; set; }
        public int FundCategoryId { get; set; }

        //Just id in staff, not foreign key
        public int StaffId { get; set; }

    }
}
