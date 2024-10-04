using GamblingMoneyTracker.Models;
using Microsoft.EntityFrameworkCore;

namespace GamblingMoneyTracker.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Player> Players { get; set; }

        public DbSet<Transaction> Transactions { get; set; }
    }
}
