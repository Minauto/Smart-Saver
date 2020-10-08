using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace SmartSaver
{
    class AccountCreator
    {
        public bool Create (string username, string password, string name, string surname)
        {
            string workingDirectory = Environment.CurrentDirectory;
            string sourcePath = Directory.GetParent(workingDirectory).Parent.FullName;

            sourcePath = sourcePath + @"\Database2.mdf";
            //MessageBox.Show(sourcePath);

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + sourcePath + ";Integrated Security=True");



            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) From Account where Username='" + username + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows[0][0].ToString() == "0")
            {

                System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
                cmd.CommandType = System.Data.CommandType.Text;

                //Creatign Table for new user


                //var commandStr = "If not exists (select name from sysobjects where name = 'Customer') CREATE TABLE Customer(First_Name char(50),Last_Name char(50),Address char(50),City char(50),Country char(25),Birth_Date datetime)";

                var commandStr = "If not exists (select name from sysobjects where name = '" + username + "') CREATE TABLE " + username + "  (Id int IDENTITY(1,1) PRIMARY KEY,Expenses float,ExpensesType nvarchar(50) ,Date datetime)";

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
                    return false;
                }

                con.Close();


                //Creating the user row in Account Table (Database2)


                cmd.CommandText = "INSERT Account  (Username, Password, Name, Surname) VALUES ('" + username + "', '" + password + "', '" + name + "', '" + surname + "')";  //SQL sentences
                cmd.Connection = con;

                con.Open();

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Account created");
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc + "Failed to connect to SQL server");
                    return false;
                }
                con.Close();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
