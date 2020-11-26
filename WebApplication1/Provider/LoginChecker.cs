﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Utility;

namespace WebApplication1.Provider
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
                return false;
            }
        }
    }
}