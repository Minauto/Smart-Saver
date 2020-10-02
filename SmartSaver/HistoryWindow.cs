using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

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

        private void openFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                InitialDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + @"\res",
                Title = "Browse XML files",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "xml",
                Filter = "XML files (*.xml)|*.xml",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };
  

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                openDeposits(openFileDialog.FileName);
            }
        }

        private void openDeposits(string fileName)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Deposit>));
            StreamReader rfile = new StreamReader(fileName);
            List<Deposit> newDeposits = (List<Deposit>)xmlSerializer.Deserialize(rfile);
            rfile.Close();
            account.setDeposits(newDeposits);
        }

        private void saveToFileButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                InitialDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + @"\res", 

                DefaultExt = "xml",
                Filter = "XML files (*.xml)|*.xml",
                FilterIndex = 2,
                RestoreDirectory = true,
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                saveDeposits(saveFileDialog.FileName);
            }
        }

        private void saveDeposits(string fileName)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Deposit>));
            var wfile = new StreamWriter(fileName);
            xmlSerializer.Serialize(wfile, account.GetDeposits());
            wfile.Close();
        }
    }
}
