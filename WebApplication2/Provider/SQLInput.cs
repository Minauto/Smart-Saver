using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Models;
using WebApplication2.Utility;

namespace WebApplication1.Provider
{
    class SQLInput
    {

        static string workingDirectory = Environment.CurrentDirectory;
        static string sourcePath = Directory.GetParent(workingDirectory).Parent.FullName + @"\Database.mdf";

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + sourcePath + ";Integrated Security=True");

        public bool CreateAccount(string username, string password, string name, Gender gender)
        {

            string genderStr = gender.ToString();
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) From Account where Username='" + username + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows[0][0].ToString() == "0")
            {

                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;

                HashSalt hashSalt = HashSalt.GenerateSaltedHash(password);

                cmd.CommandText = "INSERT Account  (Username, Nickname, Hash, Salt, Gender) VALUES ('" + username + "', '" + name + "', '" + hashSalt.Hash + "', '" + hashSalt.Salt + "', '" + genderStr + "')";  //SQL sentences
                cmd.Connection = con;

                con.Open();

                try
                {
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (Exception exc)
                {
                    return false;
                }
                finally
                {
                    con.Close();
                }
            }
            else
            {
                return false;
            }
        }
        public bool CreateExpenses(int UserId, float Expenses, String ExpensesType, DateTime Date)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;

            String dt = Date.ToString();
            try
            {
                Date = DateTime.ParseExact(dt, "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
                dt = Date.ToString("MM/dd/yyyy HH:mm:ss");
            }
            catch (Exception)
            {
            }

            cmd.CommandText = "INSERT ExpensesData  (UserId, Expenses, ExpensesType, Date) VALUES ('" + UserId + "', '" + Expenses + "', '" + ExpensesType + "', '" + dt + "')";
            cmd.Connection = con;

            con.Open();

            try
            {
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception exc)
            {
                return false;
            }
            finally
            {
                con.Close();
            }
        }

        public bool CreateBaseExpensesTypes(int UserId)
        {

            string[] typesArr = new string[] { "Groceries", "Eating Out", "Bills", "Leisure", "Fuel", "Gifts", "New Stuff", "Other" };

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;

            cmd.Connection = con;
            con.Open();

            for (int i = 0; i < typesArr.Length; i++)
            {
                cmd.CommandText = "INSERT ExpensesTypes  (UserId, ExpensesType) VALUES ('" + UserId + "', '" + typesArr[i] + "')";

                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception exc)
                {
                    return false;
                }
            }
            con.Close();
            return true;
        }

        public bool AddExpensesType(int userId, string NewExpenseType)
        {


            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("Select Count(*) From ExpensesTypes WHERE UserId = '" + userId + "' and ExpensesType = '" + NewExpenseType + "'", con);
            cmd.CommandType = CommandType.Text;

            try
            {
                con.Open();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                con.Close();
                da.Dispose();
            }
            catch (Exception)
            {

            }

            if (dt.Rows[0][0].ToString() == "0")
            {
                cmd.CommandText = "INSERT ExpensesTypes  (UserId, ExpensesType) VALUES ('" + userId + "', '" + NewExpenseType + "')";
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
            else
            {
                return false;
            }

        }

        public bool AddLimit(int userId, int Limit)
        {

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "UPDATE Account SET Limit = '" + Limit + "' WHERE Id = '" + userId + "'";
            cmd.Connection = con;


            con.Open();

            try
            {
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                con.Close();
            }
        }

        public bool updateName(int userId, string name)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "UPDATE Account SET Nickname = '" + name + "' WHERE Id = '" + userId + "'";
            cmd.Connection = con;

            con.Open();

            try
            {
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                con.Close();
            }
        }

        public bool updateTheme(int userId, Themes themes)
        {
            string themesStr = themes.ToString();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "UPDATE Account SET Theme = '" + themesStr + "' WHERE Id = '" + userId + "'";
            cmd.Connection = con;

            con.Open();
            try
            {
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception exc)
            {
                return false;
            }
            finally
            {
                con.Close();
            }
        }
    }
}