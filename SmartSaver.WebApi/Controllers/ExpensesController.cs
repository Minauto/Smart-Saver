using Microsoft.AspNetCore.Mvc;
using SmartSaver.Core;
using SmartSaver.DB;
using System.Collections.Generic;
using System.Linq;

namespace SmartSaver.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ExpensesController : ControllerBase
    {
        private IExpensesServices _expensesServices;
        private IAccountServices _accountServices;

        public ExpensesController(IExpensesServices expensesServices, IAccountServices accountServices)
        {
            _expensesServices = expensesServices;
            _accountServices = accountServices;
        }

        [HttpGet]
        public IActionResult GetExpenses()
        {
            return Ok(_expensesServices.GetExpenses());
        }

        [HttpGet("{skipAmmount} / {nickname}")]
        public IActionResult GetExpensesByUserID(int skipAmmount, string nickName)
        {
            int takeAmmount = 10;

            List<Expense> expenses = _expensesServices.GetExpensesList();
            List<Account> accounts = _accountServices.GetAccountList();

            var result =
                from Accounts in accounts
                join Expences in expenses on Accounts.UserId equals Expences.UserId
                where Accounts.Nickname == nickName
                select new { ExpenceName = Expences.Description, ExpenceAmmount = Expences.Amount }; 
            result.Skip(skipAmmount);
            result.Take(takeAmmount);

            return Ok(result);
        }

        [HttpGet("{id}", Name = "GetExpense")]
        public IActionResult GetExpense(int id)
        {
            return Ok(_expensesServices.GetExpense(id));
        }

        [HttpPost]
        public IActionResult CreateExpense(Expense expense)
        {
            var newExpense = _expensesServices.CreateExpense(expense);
            return CreatedAtRoute(nameof(GetExpense), new { newExpense.Id }, newExpense);
        }

        [HttpDelete]
        public IActionResult DeleteExpense(Expense expense)
        {
            _expensesServices.DeleteExpense(expense);
            return Ok();
        }

        [HttpPut]
        public IActionResult EditExpense (Expense expense)
        {
            return Ok(_expensesServices.EditExpense(expense));
        }
    }
}
