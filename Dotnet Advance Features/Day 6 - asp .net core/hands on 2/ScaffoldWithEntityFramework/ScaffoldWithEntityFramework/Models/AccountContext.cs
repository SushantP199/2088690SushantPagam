using Microsoft.EntityFrameworkCore;
using ScaffoldWithEntityFramework.Models;

namespace ScaffoldWithEntityFramework.Models
{
    public class AccountContext : DbContext
    {
        public AccountContext(DbContextOptions<AccountContext> option) : base(option)
        {

        }
        public virtual DbSet<Account> Accounts { get; set; }
    }
}
