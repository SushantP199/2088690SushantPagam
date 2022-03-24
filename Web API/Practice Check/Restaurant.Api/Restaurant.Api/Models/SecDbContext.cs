using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Restaurant.Api.Models
{
    public class SecDbContext : IdentityDbContext
    {
        public SecDbContext(DbContextOptions<SecDbContext> options) : base(options) { }
    }
}
