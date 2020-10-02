using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartSaver
{
    public partial class DepositWindow : Form
    {
        private Account account;

        // regex which matches only positive whole numbers
        private Regex regex = new Regex(@"^[1-9]\d*$");

        public DepositWindow(Account account)
        {
            InitializeComponent();
            this.account = account;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            tryAddingDeposit();
        }

        private void tryAddingDeposit()
        {
            if (regex.IsMatch(amountTextBox.Text))
            {
                account.addDeposit(int.Parse(amountTextBox.Text));
                MessageBox.Show("Deposit of " + amountTextBox.Text + " € was added to the account successfully.");
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid format of amount was entered. Make sure the number is positive and whole.");
                amountTextBox.Clear();
            }
        }
    }
}
