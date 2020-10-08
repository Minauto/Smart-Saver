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
    }
}
