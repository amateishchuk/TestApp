using System.Linq;
using TestApp.Db;
using TestApp.Db.Entities;
using TestApp.Services.Interfaces;

namespace TestApp.Services
{
    public class AccountRepository : IRepository<Account>
    {
        private readonly AccountContext _context;
        public AccountRepository(AccountContext context)
        {
            _context = context;
        }
        public IQueryable<Account> Get()
        {
            return _context.Accounts.AsQueryable();
        }
    }
}
