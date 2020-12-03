using System;
using System.Collections.Generic;
using System.Text;

namespace SmartSaver.Services
{
    public interface ILoginCheckService
    {
        bool Check(string usernameTextBox, string passwordTextBox);
    }
}
