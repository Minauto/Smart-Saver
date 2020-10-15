using System;
using System.Windows.Forms;

namespace SmartSaver
{
    public partial class SignUpWindow : Form
    {
        LoginWindow logWin = new LoginWindow();
        SQLInput accCreator = new SQLInput();

        public SignUpWindow(LoginWindow logWin)
        {
            InitializeComponent();
            this.logWin = logWin;
        }

        private void SignUpWindow_Load(object sender, EventArgs e)
        {

        }

        private void PasswordTextBok_TextChanged(object sender, EventArgs e)
        {

        }

        private void ConfirmTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void FirstNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
            logWin.Show();
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {

            if (UsernameTextBox.Text != "" && PasswordTextBox.Text != "" && FirstNameTextBox.Text != "" && LastNameTextBox.Text != "" && ConfirmTextBox.Text != "")
            {
                if (PasswordTextBox.Text == ConfirmTextBox.Text)
                {

                    if (accCreator.CreateAccount(UsernameTextBox.Text, PasswordTextBox.Text, FirstNameTextBox.Text, LastNameTextBox.Text))
                    {
                        this.Close();
                        logWin.Show();
                    }

                    else
                    {
                        MessageBox.Show("Username taken, try another one");
                    }
                    
                }
                else
                {
                    MessageBox.Show("Passwords do not match");
                }
            }
            else
            {
                MessageBox.Show("Fill out missing fields");
            } 
        }

        private void PasswordLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
