using System;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace SmartSaver
{
    class LoginChecker
    {
        static string workingDirectory = Environment.CurrentDirectory;
        static string sourcePath = Directory.GetParent(workingDirectory).Parent.FullName + @"\Database.mdf";

        public bool Check(string usernameTextBox, string passwordTextBox)
        {
            string sql = string.Format("SELECT * FROM Account WHERE Username = '{0}'", usernameTextBox);

            try
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + sourcePath + ";Integrated Security=True"))
                using (SqlCommand cm = new SqlCommand(sql, con))
                {
                    con.Open();
                    using (var dr = cm.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            string storedHash = dr["Hash"].ToString();
                            string storedSalt = dr["Salt"].ToString();


                            if (HashSalt.VerifyPassword(passwordTextBox, storedHash, storedSalt))
                            {
                                return true;
                            }
                            else
                            {
                                MessageBox.Show("Incorrect password!");
                                return false;
                            }
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQL error occurred: " + ex.Message);
            }
            return false;
        }
    }
}
