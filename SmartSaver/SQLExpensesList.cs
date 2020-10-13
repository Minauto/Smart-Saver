using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartSaver
{
    class SQLExpensesList
    {

        static string workingDirectory = Environment.CurrentDirectory;
        static string sourcePath = Directory.GetParent(workingDirectory).Parent.FullName + @"\Database2.mdf";
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
    }
}
