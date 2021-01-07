using SmartSaver.DB;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartSaver.Core
{
    public class AccountServices : IAccountServices
    {
        public Account GetAccount(string nickName)
        {
            Account account = new Account();

            return account;
        }
        public bool CreateAccount(Account account)
        {
            return true;
        }
        public bool DeleteAccount(string nickName)
        {
            return true;
        }
        public bool ChangeAccountPassword(string nickName, string newPass)
        {
            return true;
        }
    }
}
