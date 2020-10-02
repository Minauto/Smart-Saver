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
    public partial class HistoryWindow : Form
    {
        private Account account;

        public HistoryWindow(Account account)
        {
            InitializeComponent();

            this.account = account;

            dataGridView1.DataSource = account.GetDeposits(); 
        }

       

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
