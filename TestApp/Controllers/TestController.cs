using Microsoft.AspNetCore.Mvc;
using TestApp.Db.Entities;
using TestApp.Services.Interfaces;

namespace TestApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private IRepository<Account> _accountRepository;
        public TestController(IRepository<Account> repository)
        {
            _accountRepository = repository;
        }
    }
}
