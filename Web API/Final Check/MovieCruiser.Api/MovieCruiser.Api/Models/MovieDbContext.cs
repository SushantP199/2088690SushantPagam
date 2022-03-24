using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MovieCruiser.Api.Models
{
    public class MovieDbContext : IdentityDbContext
    {
        public MovieDbContext(DbContextOptions<MovieDbContext> options) : base(options) { }
    }
}