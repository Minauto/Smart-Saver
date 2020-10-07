using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartSaver
{
    public partial class SignUpWindow : Form
    {

        LoginWindow logWin = new LoginWindow();
        public SignUpWindow(LoginWindow logWin)
        {
            InitializeComponent();
            this.logWin = logWin;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void LastName_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void ConfirmTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void FirstNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void UsernameLabel_Click(object sender, EventArgs e)
        {

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
            logWin.Show();
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {

            string workingDirectory = Environment.CurrentDirectory;
            string sourcePath = Directory.GetParent(workingDirectory).Parent.FullName;

            sourcePath = sourcePath + @"\Database2.mdf";
            //MessageBox.Show(sourcePath);

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + sourcePath + ";Integrated Security=True");

            

            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) From Account where Username='" + UsernameTextBox.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (UsernameTextBox.Text != "" && PasswordTextBox.Text != "" && FirstNameTextBox.Text != "" && LastNameTextBox.Text != "" && ConfirmTextBox.Text != "")
            {
                if (dt.Rows[0][0].ToString() == "0")
                {
                    if (PasswordTextBox.Text == ConfirmTextBox.Text)
                    {
                        

                        System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
                        cmd.CommandType = System.Data.CommandType.Text;

                        //Creatign Table for new user


                        //var commandStr = "If not exists (select name from sysobjects where name = 'Customer') CREATE TABLE Customer(First_Name char(50),Last_Name char(50),Address char(50),City char(50),Country char(25),Birth_Date datetime)";

                        var commandStr = "If not exists (select name from sysobjects where name = '" + UsernameTextBox.Text + "') CREATE TABLE " + UsernameTextBox.Text + "  (Id int IDENTITY(1,1) PRIMARY KEY,Expenses float,ExpensesType nvarchar(50) ,Date datetime)";

                        con.Open();

                        try
                        {
                            using (SqlCommand command = new SqlCommand(commandStr, con))
                                command.ExecuteNonQuery();
                            MessageBox.Show("Table created");

                        }
                        catch (Exception exc)
                        {
                            MessageBox.Show(exc + "Failed to Create SQL Database Table");
                        }

                        con.Close();


                        //Creating the user row in Account Table (Database2)

                        
                        cmd.CommandText = "INSERT Account  (Username, Password, Name, Surname) VALUES ('" + UsernameTextBox.Text + "', '" + PasswordTextBox.Text + "', '" + FirstNameTextBox.Text + "', '" + LastNameTextBox.Text + "')";  //SQL sentences
                        cmd.Connection = con;

                        con.Open();

                        try
                        {

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Account created");

                            this.Close();
                            logWin.Show();
                        }
                        catch (Exception exc)
                        {
                            MessageBox.Show(exc + "Failed to connect to SQL server");
                        }

                        con.Close();

                    }

                    else
                    {
                        MessageBox.Show("Passwords do not match");
                    }
                }
                else
                {
                    MessageBox.Show("Username taken, try another one");
                }
            }
            else
            {
                MessageBox.Show("Fill out missing fields");
            }

            



        }
    }
}
