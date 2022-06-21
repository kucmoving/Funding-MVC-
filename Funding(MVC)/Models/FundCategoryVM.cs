using System.ComponentModel.DataAnnotations;

namespace Funding_MVC_.Models
{
    public class FundCategoryVM
    {
        public int Id { get; set; }
        [Display(Name="Use of Funds")]

        [Required]
        public string Name { get; set; }

        [Display(Name="Default Amount of Funding")]

        [Range(1000, 100000, ErrorMessage = "Please Enter A Valid Number(from 1,000 to 100,000")]
        public int DefaultAmount { get; set; }
    }
}
