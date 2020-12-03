using SmartSaver.Services;
using System;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace SmartSaver
{
    class LoginChecker
    {
        private ILoginCheckService loginCheckService;

        public bool Check (string usernameTextBox, string passwordTextBox, ILoginCheckService _loginCheckService)
        {
            loginCheckService = _loginCheckService;
            return loginCheckService.Check(usernameTextBox, passwordTextBox);
        }
    }
}
