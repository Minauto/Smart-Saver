using SmartSaver.SQL;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SmartSaver.Forms
{
    public partial class Settings : Form
    {
        Account account;
        SQLExpensesTypesList sqlExpTypesList = new SQLExpensesTypesList();
        List<String> typesList = new List<string>();
        SQLInput sqlIn = new SQLInput();
        SQLExpensesList sqlExpensesList = new SQLExpensesList();
        SQLRemoveExpenseType sqlRemove = new SQLRemoveExpenseType();
        MainWindow mainWindow;

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
            for (int i = 0; i < typesList.Count; i++)
            {
                CustomizeComboBox.Items.Add(typesList[i]);
            }
        }

        private void AddNewChoiceButton_Click(object sender, EventArgs e)
        {
            if (CustomizeComboBox.Text != "")
            {
                if (sqlIn.AddExpensesType(account.UserId, CustomizeComboBox.Text))
                {
                    MessageBox.Show("Category added");
                }
                CustomizeComboBox.Text = "";
                RefreshTypesList(account.UserId);
            }
            else
            {
                MessageBox.Show("Box Is Empty!");
            }

        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (CustomizeComboBox.Text != "")
            {
                if (sqlRemove.Remove(account.UserId, CustomizeComboBox.Text))
                {
                    MessageBox.Show("Category removed");
                }
                CustomizeComboBox.Text = "";
                RefreshTypesList(account.UserId);
            }
            else
            {
                MessageBox.Show("Box Is Empty!");
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
            account.Name = ChangeNameTextBox.Text;
            mainWindow.ReloadData();
            usernameLabel.Text = account.Name;
            sqlIn.updateName(account.UserId, account.Name);
        }

        private void ChangeThemeButton_Click(object sender, EventArgs e)
        {
            mainWindow.changeTheme();
        }
    }
}
