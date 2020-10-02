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

        public DepositWindow(Account account)
        {
            InitializeComponent();
            this.account = account;
        }

        private Regex regex = new Regex(@"^[1-9]\d*$");

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (regex.IsMatch(amountTextBox.Text))
            {
                account.addDeposit(int.Parse(amountTextBox.Text));
                this.Close();
            }
            else
            {
                MessageBox.Show("bad");
                amountTextBox.Clear();
            }
        }
    }
}
