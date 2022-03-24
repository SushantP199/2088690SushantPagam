using Microsoft.AspNetCore.Identity;

namespace Restaurant.Api.Models
{
    public class AppUser : IdentityUser
    {
        public string FullName { get; set; }
     
        public int? Age { get; set; }
    }
}
