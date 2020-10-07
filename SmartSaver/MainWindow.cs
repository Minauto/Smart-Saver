using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartSaver
{
    public partial class MainWindow : Form
    {
        Account account;

        public MainWindow()
        {
            InitializeComponent();

            account = new Account("laurynasn", "Laurynas", "Notrumas", 19, "pass123");
            UpdateBalance();
        }
        private void balanceBtn_Click(object sender, EventArgs e)
        {
            
            
            
            //MessageBox.Show("Your remaining balance is $1
        }

        private void historyBtn_Click(object sender, EventArgs e)
        {
            HistoryWindow hw = new HistoryWindow(account);
            hw.Show();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void addADepositBtn_Click(object sender, EventArgs e)
        {
            DepositWindow dw = new DepositWindow(account, this);
            dw.Show();
            UpdateBalance();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
        private void AddAWithdrawal_Click(object sender, EventArgs e)
        {

        }

        public void UpdateBalance()
        {
            BalanceDisplay.Text = "Your balance is " + account.Balance.ToString() + "€!";
        }

    }
}
