using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartSaver.SQL
{
    class SQLRemoveExpenseType
    {
        static string workingDirectory = Environment.CurrentDirectory;
        static string sourcePath = Directory.GetParent(workingDirectory).Parent.FullName + @"\Database2.mdf";

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + sourcePath + ";Integrated Security=True");

        public void Remove(int userId, string expenseType)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "DELETE FROM ExpensesTypes WHERE UserId = '"+userId+"' and ExpensesType = '"+expenseType+"'";
            cmd.Connection = con;

            con.Open();
            try
            {
                cmd.ExecuteNonQuery();

            }
            catch (Exception)
            {
                MessageBox.Show("Failed To Delete");
            }
            con.Close();

        }
    }
}
