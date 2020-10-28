using SmartSaver.SQL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartSaver.Forms
{
    public partial class Settings : Form
    {
        Account account;
        SQLExpensesTypesList sqlExpTypesList = new SQLExpensesTypesList();
        List<String> typesList = new List<string>();
        SQLInput sqlIn = new SQLInput();
        SQLRemoveExpenseType sqlRemove = new SQLRemoveExpenseType();

        public Settings(Account account)
        {
            InitializeComponent();
            this.account = account;
            RefreshTypesList(this.account.UserId);
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
            if(CustomizeComboBox.Text != "")
            {
                sqlIn.AddExpensesType(account.UserId, CustomizeComboBox.Text);
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
                sqlRemove.Remove(account.UserId, CustomizeComboBox.Text);
                CustomizeComboBox.Text = "";
                RefreshTypesList(account.UserId);
        }
    }
}
