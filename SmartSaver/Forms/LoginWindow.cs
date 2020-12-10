using Newtonsoft.Json;
using SmartSaver.Forms;
using SmartSaver.Services;
using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartSaver
{
    public partial class LoginWindow : Form
    {
        delegate void MSG(string text);
        MSG msg = delegate (string text) { MessageBox.Show(text); };

        Account account;
        LoginChecker checker = new LoginChecker();
        SQLLoginReader Reader = new SQLLoginReader();
        SQLInput sqlIn = new SQLInput();
        SQLExpensesTypesList sqlExTypeList = new SQLExpensesTypesList();
        //ILoginCheckService loginCheckService = new LoginCheckService();
        private readonly ILoginCheckService _loginCheckService;

        public LoginWindow(ILoginCheckService loginCheckService)
        {
            _loginCheckService = loginCheckService;

            InitializeComponent();
        }


        private async void LogInButton_Click(object sender, EventArgs e, ILoginCheckService _loginCheckService)
        {
            
            
            if (checker.Check(usernameTxtBx.Text, passwdTxtBx.Text, _loginCheckService))
            {
                RestClient rClient = new RestClient();
                rClient.endPoint += usernameTxtBx.Text;

                string strResponse = string.Empty;

                Task<string> result = rClient.makeRequest();

                LoadingLabel.Text = "Loading...";
                LoadingLabel.Visible = true;

                //strResponse = await result;

                account = JsonConvert.DeserializeObject<Account>(strResponse);

                
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
                msg("Please Check Username and Password");
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
                LogInButton_Click(this, new EventArgs(), _loginCheckService);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
    }
}
