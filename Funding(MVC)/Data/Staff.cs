using Microsoft.AspNetCore.Identity;

namespace Funding_MVC_.Data
{
    public class Staff : IdentityUser
    {
        public string? Name { get; set; }
        public string? Nickname { get; set; }
        public string? staffId { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime DateOfJoined { get; set; }

    }
}
