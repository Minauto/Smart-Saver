using System;
using System.Windows.Forms;

namespace SmartSaver
{
    public partial class LoginWindow : Form
    {
        LoginStruct LogInStr = new LoginStruct();
        LoginChecker checker = new LoginChecker();
        SQLLoginReader Reader = new SQLLoginReader();
        SQLInput sqlIn = new SQLInput();
        SQLExpensesTypesList sqlExTypeList = new SQLExpensesTypesList();

        public LoginWindow()
        {
            InitializeComponent();
        }

        private void LogInButton_Click(object sender, EventArgs e)
        {

            if (checker.Check(usernameTxtBx.Text, passwdTxtBx.Text))
            {
                LogInStr = Reader.Read(usernameTxtBx.Text);
                if (sqlExTypeList.CheckIfEmpty(LogInStr.userId))
                {
                    sqlIn.CreateBaseExpensesTypes(LogInStr.userId);
                }
                this.Hide();
                MainWindow loggedInWindow = new MainWindow(this, LogInStr.username, LogInStr.name, LogInStr.userId, LogInStr.gender, LogInStr.limit);
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
