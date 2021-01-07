using Microsoft.AspNetCore.Mvc;
using SmartSaver.Core;
using SmartSaver.DB;

namespace SmartSaver.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AccountController : ControllerBase
    {
        private IAccountServices _accountServices;

        public AccountController(IAccountServices accountServices)
        {
            _accountServices = accountServices;
        }

        [HttpGet("{nickname}")]
        public IActionResult GetAccount(string nickname)
        {
            return Ok(_accountServices.GetAccount(nickname));
        }

        [HttpPost("{nickname}/{password}")]
        public IActionResult CreateAccount(string nickname,string password)
        {
            Account account = new Account();
            account.Nickname = nickname;
            account.Password = password;
            return Ok(_accountServices.CreateAccount(account));
        }

        [HttpDelete("{nickname}")]
        public IActionResult DeleteAccount(string nickname)
        {
            
            return Ok(_accountServices.DeleteAccount(nickname));
        }

        [HttpPut("{nickname}/{newPassword}")]
        public IActionResult ChangeAccountPassword(string nickname, string newPassword)
        {
            return Ok(_accountServices.ChangeAccountPassword(nickname,newPassword));
        }
    }
}
