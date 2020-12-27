using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Data;
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
        LoginChecker checker = new LoginChecker();
        SQLLoginReader sqlLogRead = new SQLLoginReader();
        SQLInput sqlIn = new SQLInput();
        SQLExpensesTypesList sqlExpensesTypesList = new SQLExpensesTypesList();


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
        // GET api/account/firstname/password
        [HttpGet("{firstName}/{password}")]
        public bool CheckLogInInfo(string firstName, string password)
        {
            bool boool;
            boool = checker.Check(firstName, password);
            return boool;
        }
        // GET api/account/data/types/id
        [HttpGet("data/types/{id}")]
        public List<String> GetDataTable(int id)
        {

            List<String> list;
            list = sqlExpensesTypesList.GetExpensesTypes(id);
            return list;
        }

    }
}
