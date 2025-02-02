﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Provider
{
    class SQLExpensesList
    {

        static string workingDirectory = Environment.CurrentDirectory;
        static string sourcePath = Directory.GetParent(workingDirectory).Parent.FullName + @"\Smart-Saver\SmartSaver\Database.mdf"; // fix this later
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

                sTable.AsEnumerable().Take(1);

                return sTable;
            }
            catch (Exception)
            {
                DataTable dt = new DataTable();
                return dt;
            }

        }

        public DataTable GetExpensesSumByType(int UserId)
        {
            try
            {
                string sql = "SELECT SUM (Expenses) AS SumOfExpences, ExpensesType AS TypeOfExpences FROM ExpensesData WHERE UserId = " + UserId + " GROUP BY ExpensesType";
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
                return 0;
            }
        }
    }
}
