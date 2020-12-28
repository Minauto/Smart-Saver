using Saver.Services;
using System;
using System.Windows.Forms;

namespace Saver
{
    public partial class SignUpWindow : Form
    {
        delegate void MSG(string text);
        MSG msg = delegate (string text) { MessageBox.Show(text); };
        
        LoginWindow logWin = new LoginWindow(new LoginCheckService());
        SQLInput accCreator = new SQLInput();

        public SignUpWindow(LoginWindow logWin)
        {
            InitializeComponent();
            this.logWin = logWin;
            GenderComboBox.DataSource = Enum.GetValues(typeof(Gender));
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
            logWin.Show();
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            if (UsernameTextBox.Text != "" && PasswordTextBox.Text != "" && FirstNameTextBox.Text != "" && ConfirmTextBox.Text != "")
            {
                if (PasswordTextBox.Text == ConfirmTextBox.Text)
                {
                    Gender gender;
                    Enum.TryParse<Gender>(GenderComboBox.SelectedValue.ToString(), out gender);
                    if (accCreator.CreateAccount(UsernameTextBox.Text, PasswordTextBox.Text, FirstNameTextBox.Text, gender))
                    {
                        this.Close();
                        logWin.Show();
                    }
                    else
                    {
                        msg("Username taken, try another one");
                    }
                }
                else
                {
                    msg("Passwords do not match");
                }
            }
            else
            {
                msg("Fill out missing fields");
            }
        }
    }
}
