using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Provider
{
    class SQLExpensesTypesList
    {

        static string workingDirectory = Environment.CurrentDirectory;
        static string sourcePath = Directory.GetParent(workingDirectory).Parent.FullName + @"\Database.mdf";
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + sourcePath + ";Integrated Security=True");

        private DataTable dataTable = new DataTable();

        private bool FillDataTable(int userId)
        {
            dataTable.Clear();
            try
            {
                SqlCommand cmd = new SqlCommand("Select * From ExpensesTypes WHERE UserId = '" + userId + "'", con);
                con.Open();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dataTable);

                con.Close();
                da.Dispose();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<String> GetExpensesTypes(int userId)
        {
            FillDataTable(userId);
            List<String> typesList = new List<string>();

            foreach (DataRow row in dataTable.Rows)
            {
                typesList.Add(row["ExpensesType"].ToString());
            }


            return typesList;
        }

        public bool CheckIfEmpty(int userId)
        {
            DataTable dt = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand("Select Count(*) From ExpensesTypes WHERE UserId = '" + userId + "'", con);
                con.Open();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                con.Close();
                da.Dispose();
            }
            catch (Exception)
            {

            }

            if (dt.Rows[0][0].ToString() != "0")
            {
                return false;
            }
            else
            {
                return true;
            }

        }

    }
}