using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Reflection;
using System.IO;

namespace SmartSaver
{
    public partial class LoginWindow : Form
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void LoginWindow_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            string workingDirectory = Environment.CurrentDirectory;
            string sourcePath = Directory.GetParent(workingDirectory).Parent.FullName;

            
            sourcePath = sourcePath + @"\Database2.mdf";
            //MessageBox.Show(sourcePath);
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + sourcePath + ";Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) From Account where Username='" + UsernameTextBox.Text + "' and Password = '" + PasswordTextBox.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                //Connecting to user data in Account table

                SqlCommand cmd = new SqlCommand("Select * From Account Where Username='" + UsernameTextBox.Text + "'", con);
                con.Open();
                
                
                try
                {

                    SqlDataReader reader = cmd.ExecuteReader();
                    reader.Read();

                    string username = reader["Username"].ToString();
                    string password = reader["Password"].ToString();
                    string name = reader["Name"].ToString();
                    string surname = reader["Surname"].ToString();

                    this.Hide();
                    MainWindow loggedInWindow = new MainWindow(this, sourcePath, username, name, surname, password);
                    loggedInWindow.Show();

                } 
                catch(Exception exc)
                {
                    MessageBox.Show(exc + "Reader failed to open");
                }
                
                con.Close();
                

            }
            else
            {
                MessageBox.Show("Please Check Username and Password");
            }
            
            
        }

        public void ShowWindow()
        {
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUpWindow signUpWin = new SignUpWindow(this);
            signUpWin.Show();
        }
    }
}
