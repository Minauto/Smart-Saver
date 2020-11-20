using System;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace SmartSaver
{
    class SQLLoginReader
    {
        Account account = new Account();
        static string workingDirectory = Environment.CurrentDirectory;
        static string sourcePath = Directory.GetParent(workingDirectory).Parent.FullName + @"\Database.mdf";
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + sourcePath + ";Integrated Security=True");

        public Account Read(string username)
        {

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Select * From Account WHERE Username = '" + username + "'", con);
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();

                String userRead = reader["Username"].ToString();
                String nameRead = reader["Nickname"].ToString();
                int IdRead = Int32.Parse(reader["Id"].ToString());
                Gender genderRead;
                Enum.TryParse<Gender>(reader["Gender"].ToString(), out genderRead);
                int limitRead = Int32.Parse(reader["Limit"].ToString());
                Themes themesRead;
                Enum.TryParse<Themes>(reader["Theme"].ToString(), out themesRead);

                reader.Close();
                con.Close();

                account.Nickname = userRead;
                account.Name = nameRead;
                account.UserId = IdRead;
                account.gender = genderRead;
                account.Limit = limitRead;
                account.themes = themesRead;

                return account;
            }
            catch (Exception exc)
            {
                con.Close();
                MessageBox.Show(exc + "Error");
                return account;
            }
        }
    }
}
