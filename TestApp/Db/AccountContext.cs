using Microsoft.EntityFrameworkCore;
using TestApp.Db.Entities;

namespace TestApp.Db
{
    public class AccountContext : DbContext
    {
        public AccountContext(DbContextOptions<AccountContext> options) : base(options) { }

        public DbSet<Account> Accounts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            for (var i = 0; i < 50; i++)
            {
                modelBuilder.Entity<Account>().HasData(new Account
                {
                    Id = i + 1,
                    Address = "Address1",
                    Email = "email@email.com",
                    FacebookLink = "facebook.com",
                    FirstName = "FN",
                    LastName = "LN",
                    PhoneNumber = "380....",
                    TwitterLink = "twitter.com"
                });
            }
        }
    }
}
