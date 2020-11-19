using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace SmartSaver
{
    class SQLExpensesList
    {

        static string workingDirectory = Environment.CurrentDirectory;
        static string sourcePath = Directory.GetParent(workingDirectory).Parent.FullName + @"\Database.mdf";
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + sourcePath + ";Integrated Security=True");

        SqlCommand sCommand;
        SqlDataAdapter sAdapter;
        SqlCommandBuilder sBuilder;
        DataSet sDs;
        DataTable sTable;

        public DataTable GetExpenses(int UserId)
        {
            try
            {
                string sql = "SELECT Expenses, ExpensesType, Date FROM ExpensesData WHERE UserId = " + UserId + "";
                con.Open();
                sCommand = new SqlCommand(sql, con);
                sAdapter = new SqlDataAdapter(sCommand);
                sBuilder = new SqlCommandBuilder(sAdapter);
                sDs = new DataSet();
                sAdapter.Fill(sDs, "ExpensesData");
                sTable = sDs.Tables["ExpensesData"];
                con.Close();

                return sTable;
            }
            catch (Exception)
            {
                MessageBox.Show("SQLExpensesList error");
                DataTable dt = new DataTable();
                return dt;
            }

        }

        public DataTable GetExpensesSumByType(int UserId)
        {
            try
            {
                string sql = "SELECT SUM (Expenses), ExpensesType FROM ExpensesData WHERE UserId = " + UserId + " GROUP BY ExpensesType";
                con.Open();
                sCommand = new SqlCommand(sql, con);
                sAdapter = new SqlDataAdapter(sCommand);
                sBuilder = new SqlCommandBuilder(sAdapter);
                sDs = new DataSet();
                sAdapter.Fill(sDs, "ExpensesData");
                sTable = sDs.Tables["ExpensesData"];
                con.Close();

                return sTable;
            }
            catch (Exception)
            {
                MessageBox.Show("SQLExpensesList error");
                DataTable dt = new DataTable();
                return dt;
            }

        }

        public float GetSumOfExpenses(int UserId)
        {
            con.Open();
            SqlCommand query = new SqlCommand("SELECT SUM(Expenses) FROM ExpensesData WHERE UserId = " + UserId + " AND DATEDIFF(month, date, CURRENT_TIMESTAMP) = 0");
            query.Connection = con;
            try
            {
                object monthlyExpenses = query.ExecuteScalar();
                con.Close();

                float monthlyExpensesFloat = float.Parse(Convert.ToString(monthlyExpenses));
                return monthlyExpensesFloat;
            }
            catch (Exception)
            {

            }

            return 0;
        }
    }
}
