using System;
using System.Collections.Generic;
using System.Text;

namespace Saver.Services
{
    public interface ILoginCheckService
    {
        bool Check(string usernameTextBox, string passwordTextBox);
    }
}
