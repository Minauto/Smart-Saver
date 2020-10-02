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
        }
        private void balanceBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your remaining balance is $100");
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
            DepositWindow dw = new DepositWindow(account);
            dw.Show();
        }
    }
}
