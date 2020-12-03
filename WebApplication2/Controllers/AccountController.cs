using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Provider;

namespace WebApplication2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AccountController : ControllerBase
    {
        Account account = new Account();
        SQLLoginReader sqlLogRead = new SQLLoginReader();

        

        private readonly ILogger<AccountController> _logger;

        public AccountController(ILogger<AccountController> logger)
        {
            _logger = logger;
        }
        
        [HttpGet]
        public Account GetAccount()
        {
            account = sqlLogRead.Read("Minde");
            return account;
        }

        // GET api/account/firstname
        [HttpGet("{firstName}")]
        public Account GetAccountWithParameters(string firstName)
        {
            account = sqlLogRead.Read(firstName);
            return account;
        }
    }
}
