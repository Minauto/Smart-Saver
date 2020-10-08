using System;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace SmartSaver
{
    class SQLReader
    {
        static string workingDirectory = Environment.CurrentDirectory;
        static string sourcePath = Directory.GetParent(workingDirectory).Parent.FullName + @"\Database2.mdf";
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + sourcePath + ";Integrated Security=True");

        //Connecting to user data in Account table

        public string Read(string tableName, string condition, string columnName)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Select * From " + tableName + " " + condition + "", con);
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();

                string value = reader[""+columnName+""].ToString();

                reader.Close();

                return value;
            }

            catch (Exception exc)
            {
                MessageBox.Show(exc + "Error");
                return "";
            }

        }

        public void ConnectionOpen ()
        {
            con.Open();
        }

        public void ConnectionClose ()
        {
            con.Close();
        }
/*
        SqlCommand cmd = new SqlCommand("Select * From Account Where Username='" + usernameTxtBx.Text + "'", con);
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
*/



    }
}
