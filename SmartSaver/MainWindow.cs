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
        LoginWindow logWin = new LoginWindow();
        string databasePath;

        public MainWindow(LoginWindow logWin, String databasePath, String username, String name, String surname, String password)
        {
            // To access database use Select sentences as follows: "select * From " + username + " where condition "
            // There are 4 columns :
            //  Id which is generated on its own [int]
            //  Expenses is price spent [float]
            //  ExpensesType is what you spent it on [nvarchar(50)]
            //  Date used for storing the date of record [datetime]

            InitializeComponent();
            this.logWin = logWin;
            this.databasePath = databasePath;
            account = new Account(username, name, surname, password);
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
            logWin.Show();
            
        }

        private void addADepositBtn_Click(object sender, EventArgs e)
        {
            DepositWindow dw = new DepositWindow(account);
            dw.Show();
        }
    }
}
