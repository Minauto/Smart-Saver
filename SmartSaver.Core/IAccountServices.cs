using SmartSaver.DB;
using System.Collections.Generic;
using System.Text;

namespace SmartSaver.Core
{
    public interface IAccountServices
    {
        Account GetAccount(string nickName);
        bool CreateAccount(Account account);
        bool DeleteAccount(string nickName);
        bool ChangeAccountPassword(string nickName,string newPass);
        List<Account> GetAccountList();
    }
}
