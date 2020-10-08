﻿using System;
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

        public MainWindow(LoginWindow logWin, String username, String name, String surname, String password)
        {
            InitializeComponent();
            this.logWin = logWin;
            account = new Account(username, name, surname, password);
        }
        private void BalanceButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your remaining balance is $100");
        }

        private void HistoryButton_Click(object sender, EventArgs e)
        {
            HistoryWindow hw = new HistoryWindow(account);
            hw.Show();
        }

        private void ExitButton_Click(object sender, EventArgs e)
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
