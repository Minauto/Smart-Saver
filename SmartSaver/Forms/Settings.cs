using SmartSaver.SQL;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SmartSaver.Forms
{
    public partial class Settings : Form
    {
        delegate void MSG(string text);
        MSG msg = delegate (string text) { MessageBox.Show(text); };

        Account account;
        SQLExpensesTypesList sqlExpTypesList = new SQLExpensesTypesList();
        List<String> typesList = new List<string>();
        SQLInput sqlIn = new SQLInput();
        SQLExpensesList sqlExpensesList = new SQLExpensesList();
        SQLRemoveExpenseType sqlRemove = new SQLRemoveExpenseType();
        MainWindow mainWindow;
        Themes themes;
        Theme theme;

        public Settings(Account account, MainWindow mainWindow)
        {
            InitializeComponent();
            this.account = account;
            RefreshTypesList(this.account.UserId);
            usernameLabel.Text = account.Name;
            this.mainWindow = mainWindow;
        }
        private void RefreshTypesList(int userId)
        {
            CustomizeComboBox.Items.Clear();
            typesList = sqlExpTypesList.GetExpensesTypes(userId);
            typesList.ForEach(delegate (string s) { CustomizeComboBox.Items.Add(s); });
        }

        private void AddNewChoiceButton_Click(object sender, EventArgs e)
        {
            if (CustomizeComboBox.Text != "")
            {
                if (sqlIn.AddExpensesType(account.UserId, CustomizeComboBox.Text))
                {
                    msg("Category added");
                }
                CustomizeComboBox.Text = "";
                RefreshTypesList(account.UserId);
            }
            else
            {
                msg("Box Is Empty!");
            }

        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (CustomizeComboBox.Text != "")
            {
                if (sqlRemove.Remove(account.UserId, CustomizeComboBox.Text))
                {
                    msg("Category removed");
                }
                CustomizeComboBox.Text = "";
                RefreshTypesList(account.UserId);
            }
            else
            {
                msg("Box Is Empty!");
            }
        }

        private void changeNameButton_Click(object sender, EventArgs e)
        {
            ShowChangeNickname();
        }

        private void ShowChangeNickname()
        {
            ChangeNamePanel.Visible = true;
        }

        private void ExitChangeNamePanel_Click(object sender, EventArgs e)
        {
            ChangeNamePanel.Visible = false;
            ChangeNameTextBox.Text = "";
        }

        private void SetNewNameButton_Click(object sender, EventArgs e)
        {
            if (ChangeNameTextBox.Text != "")
            {
                SetNewName();
            }
            else
            {
                MessageBox.Show("Box Is Empty!");
            }
        }

        private void SetNewName()
        {
            account.Name = ChangeNameTextBox.Text;
            mainWindow.ReloadData();
            usernameLabel.Text = account.Name;
            sqlIn.updateName(account.UserId, account.Name);
        }

        private void ChangeThemeButton_Click(object sender, EventArgs e)
        {
            if (account.themes == Themes.Dark)
            {
                sqlIn.updateTheme(account.UserId, Themes.Light);
                account.themes = Themes.Light;
            }
            else
            {
                sqlIn.updateTheme(account.UserId, Themes.Dark);
                account.themes = Themes.Dark;
            }
            theme = new Theme(account.themes);

            mainWindow.changeTheme(theme);
        }
    }
}
