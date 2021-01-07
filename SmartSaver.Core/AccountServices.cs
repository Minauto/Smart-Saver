using SmartSaver.DB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.IO;
using Microsoft.Data.SqlClient;

namespace SmartSaver.Core
{
    public class AccountServices : IAccountServices
    {

        SqlConnection con = new SqlConnection(@"Server=(localdb)\mssqllocaldb;Database=SmartSaverDB;Integrated Security=True");

        public Account GetAccount(string nickName)
        {
            Account account = new Account();

            return account;
        }
        public bool CreateAccount(Account account)
        {
            return true;
        }
        public bool DeleteAccount(string nickName)
        {
            SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "DELETE FROM Account WHERE Nickname = " + nickName + "'";
                cmd.Connection = con;

                con.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                    con.Close();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }

            return true;
        }
        public bool ChangeAccountPassword(string nickName, string newPass)
        {

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "UPDATE Account SET Password = " + newPass + " WHERE Nickname = " + nickName + "'";
            cmd.Connection = con;

            con.Open();
            try
            {
                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }
    }
}
