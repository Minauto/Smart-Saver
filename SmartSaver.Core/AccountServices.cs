using Microsoft.Data.SqlClient;
using SmartSaver.DB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.IO;

namespace SmartSaver.Core
{
    public class AccountServices : IAccountServices
    {

        SqlConnection con = new SqlConnection(@"Server=(localdb)\mssqllocaldb;Database=SmartSaverDB;Integrated Security=True");

        public Account GetAccount(string nickName)
        {
            Account account = new Account();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Select * From Accounts WHERE Nickname = '" + nickName + "'", con);
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();

                String nameRead = reader["Nickname"].ToString();
                int IdRead = Int32.Parse(reader["UserId"].ToString());

                reader.Close();
                con.Close();

                account.Nickname = nameRead;
                account.UserId = IdRead;

                return account;
            }
            catch (Exception exc)
            {
                con.Close();
                return account;
            }
        }

        
        public bool CreateAccount(Account account)
        {
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) From Accounts where Nickname='" + account.Nickname + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "0")
            {

                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "INSERT Accounts (Nickname, Password) VALUES ('" + account.Nickname + "', '" + account.Password + "')";
                cmd.Connection = con;

                con.Open();

                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception exc)
                {
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
        public bool DeleteAccount(string nickName)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "DELETE FROM Accounts WHERE Nickname = '" + nickName + "'";
            cmd.Connection = con;
            con.Open();
            try
            {
                cmd.ExecuteNonQuery();

            }
            catch (Exception)
            {
                return false;
            }
            con.Close();

            return true;
        }
        public bool ChangeAccountPassword(string nickName, string newPass)
        {

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "UPDATE Accounts SET Password = '" + newPass + "' WHERE Nickname = '" + nickName + "'";
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
