using System;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace SmartSaver
{
    class SQLLoginReader
    {
        LoginStruct logInStr = new LoginStruct();
        static string workingDirectory = Environment.CurrentDirectory;
        static string sourcePath = Directory.GetParent(workingDirectory).Parent.FullName + @"\Database2.mdf";
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + sourcePath + ";Integrated Security=True");

        public LoginStruct Read(string username)
        {
  
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Select * From Account WHERE Username = '" + username + "'", con);
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();

                String userRead = reader["Username"].ToString();
                String nameRead = reader["Name"].ToString();
                String surNameRead = reader["Surname"].ToString();
                int IdRead = Int32.Parse(reader["Id"].ToString());

                reader.Close();
                con.Close();

                logInStr.username = userRead;
                logInStr.name = nameRead;
                logInStr.surname = surNameRead;
                logInStr.userId = IdRead;

                return logInStr;
            }
            catch (Exception exc)
            {
                con.Close();
                MessageBox.Show(exc + "Error");
                return logInStr;
            }
        }
    }
}
