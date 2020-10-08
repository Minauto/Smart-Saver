using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace SmartSaver
{
    class LoginChecker
    {
        static string workingDirectory = Environment.CurrentDirectory;
        static string sourcePath = Directory.GetParent(workingDirectory).Parent.FullName + @"\Database2.mdf";
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + sourcePath + ";Integrated Security=True");

        public bool Check(string usernameTextBox, string passwordTextBox)
        {
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) From Account where Username='" + usernameTextBox + "' and Password = '" + passwordTextBox + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows[0][0].ToString() == "1")
            {
                return true;
            }

            else
            {
                return false;
            }
        }
    }
}
