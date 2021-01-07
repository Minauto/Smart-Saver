using Microsoft.EntityFrameworkCore;

namespace SmartSaver.DB
{
    public class AppDbContext : DbContext
    {
        public DbSet<Expense> Expenses { get; set; }
        public DbSet<Account> Accounts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server=(localdb)\mssqllocaldb;Database=SmartSaverDB;Integrated Security=True");
        }
    }
}
