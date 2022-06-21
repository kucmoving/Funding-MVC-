using AutoMapper;
using Funding_MVC_.Data;
using Funding_MVC_.Models;

namespace Funding_MVC_.Helper
{
    public class AutoMapper : Profile
    {   
        public AutoMapper()
        {
            CreateMap<FundCategory, FundCategoryVM>().ReverseMap();
        }
    }
}
