using SmartSaver.SQL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        SQLExpensesList sqlExpensesList = new SQLExpensesList();
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

        private void saveToFileButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                InitialDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + @"\res",

                DefaultExt = "json",
                Filter = "json files (*.json)|*.json",
                FilterIndex = 2,
                RestoreDirectory = true,
            };


            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                JSONUtils.saveData(sqlExpensesList.GetExpenses(account.UserId), saveFileDialog.FileName);
            }
        }

        private void openFromFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                InitialDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + @"\res",
                Title = "Browse json files",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "json",
                Filter = "json files (*.xml)|*.json",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                DataTable newDataTable = JSONUtils.openData(openFileDialog.FileName);

                expensesDataTable.DataSource = newDataTable;
                expensesDataTable.ReadOnly = true;
                expensesDataTable.Columns["Date"].Width = 120;
                expensesDataTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                expensesDataTable.Visible = true;
            }
        }
    }
    
}
