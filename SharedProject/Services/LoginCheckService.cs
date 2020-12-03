using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace SmartSaver.Services
{
    class LoginCheckService : ILoginCheckService
    {
        public bool Check(string usernameTextBox, string passwordTextBox)
        {
            string sql = string.Format("SELECT * FROM Account WHERE Username = '{0}'", usernameTextBox);

            try
            {
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["SmartSaver.Properties.Settings.Database2ConnectionString"].ConnectionString))
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
