using System.Linq;
using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Mvc;
using TestApp.Db.Entities;
using TestApp.Services.Interfaces;

namespace TestApp.Controllers
{
    public class AccountsController : ODataController
    {
        private IRepository<Account> _accountRepository;
        public AccountsController(IRepository<Account> repository)
        {
            _accountRepository = repository;
        }

        [EnableQuery()] 
        [HttpGet]
        public IQueryable<Account> Get()
        {
            var list = _accountRepository.Get().ToList();
            return _accountRepository.Get();
        }
    }
}
