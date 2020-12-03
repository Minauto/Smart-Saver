using Newtonsoft.Json;
using SmartSaver.Forms;
using SmartSaver.Services;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartSaver
{
    public partial class LoginWindow : Form
    {
        Account account;
        LoginChecker checker = new LoginChecker();
        SQLLoginReader Reader = new SQLLoginReader();
        SQLInput sqlIn = new SQLInput();
        SQLExpensesTypesList sqlExTypeList = new SQLExpensesTypesList();
        ILoginCheckService loginCheckService = new LoginCheckService();

        public LoginWindow()
        {
            InitializeComponent();
        }


        private void LogInButton_Click(object sender, EventArgs e)
        {
            
            
            if (checker.Check(usernameTxtBx.Text, passwdTxtBx.Text, loginCheckService))
            {
                /*
                RestClient rClient = new RestClient();
                rClient.endPoint += usernameTxtBx.Text;
                MessageBox.Show("Rest Client Created");

                string strResponse = string.Empty;

                strResponse = rClient.makeRequest();

                MessageBox.Show(strResponse);

                account = JsonConvert.DeserializeObject<Account>(strResponse);

                */

                account = Reader.Read(usernameTxtBx.Text);
                if (sqlExTypeList.CheckIfEmpty(account.UserId))
                {
                    sqlIn.CreateBaseExpensesTypes(account.UserId);
                }
                this.Hide();
                MainWindow loggedInWindow = new MainWindow(this, account);
                loggedInWindow.Show();
            }
            else
            {
                MessageBox.Show("Please Check Username and Password");
            }
            
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUpWindow signUpWin = new SignUpWindow(this);
            signUpWin.Show();
        }

        private void passwdTxtBx_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LogInButton_Click(this, new EventArgs());
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
    }
}
