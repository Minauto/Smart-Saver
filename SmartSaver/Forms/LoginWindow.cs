using System;
using System.Windows.Forms;

namespace SmartSaver
{
    public partial class LoginWindow : Form
    {
        LoginChecker checker = new LoginChecker();
        SQLReader Reader = new SQLReader();

        public LoginWindow()
        {
            InitializeComponent();
        }

        private void LoginWindow_Load(object sender, EventArgs e)
        {

        }

        private void PasswordLabel_Click(object sender, EventArgs e)
        {

        }

        private void UsernameTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            if (checker.Check(usernameTxtBx.Text, passwdTxtBx.Text))

                
            {
                //Connecting to user data in Account table
                Reader.ConnectionOpen();
                string condition = "WHERE Username = '" + usernameTxtBx.Text + "'";

                string username = Reader.Read("Account", condition, "Username");
                string name = Reader.Read("Account", condition, "Name");
                string surname = Reader.Read("Account", condition, "Surname");
                int userId = Int32.Parse(Reader.Read("Account", condition, "Id"));
                
                Reader.ConnectionClose();
                this.Hide();
                MainWindow loggedInWindow = new MainWindow(this, username, name, surname, userId);
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

        private void NameLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
