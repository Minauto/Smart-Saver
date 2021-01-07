using Microsoft.Data.SqlClient;
using SmartSaver.DB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace SmartSaver.Core
{
    public class ExpensesServices : IExpensesServices
    {
        private AppDbContext _context;
        private string sqlDBPath = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=SmartSaverDB;Integrated Security=True;";
        private SqlConnection connection;

        public ExpensesServices (AppDbContext context)
        {
            _context = context;
        }

        public Expense CreateExpense(Expense expense)
        {
            using (connection = new SqlConnection(sqlDBPath))
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO Expenses (Description, Amount, UserId) VALUES (@Description, @Amount, @UserId)";
                cmd.Parameters.Add(new SqlParameter("@Description", SqlDbType.NVarChar, 4000, "Description"));
                cmd.Parameters.Add(new SqlParameter("@Amount", SqlDbType.Float));
                cmd.Parameters.Add(new SqlParameter("@UserId", SqlDbType.Int));
                cmd.Parameters["@Amount"].SourceColumn = "Amount";
                cmd.Parameters["@UserId"].SourceColumn = "UserID";

                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Expenses", connection);
                SqlCommandBuilder builder = new SqlCommandBuilder(sda);

                connection.Open();
                sda.InsertCommand = cmd;

                DataSet ds = new DataSet();
                sda.Fill(ds, "Expenses");

                try
                {
                    DataRow row = ds.Tables["Expenses"].NewRow();
                    row["Description"] = expense.Description;
                    row["Amount"] = expense.Amount;
                    row["UserId"] = expense.UserId;

                    ds.Tables["Expenses"].Rows.Add(row);

                    builder.GetInsertCommand();
                    sda.Update(ds, "Expenses");
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine(ex.Message);
                }
                finally
                {
                    connection.Close();
                    sda.Dispose();
                }
            }

            return expense;

        }

        public void DeleteExpense(Expense expense)
        {
            using (connection = new SqlConnection(sqlDBPath))
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "DELETE FROM Expenses WHERE Id=" + expense.Id;
                cmd.Connection = connection;

                connection.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        public Expense EditExpense(Expense expense)
        {
            using (connection = new SqlConnection(sqlDBPath))
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "UPDATE Expenses SET Description = '" + expense.Description + "', Amount = " + expense.Amount + " WHERE Id=" + expense.Id;
                cmd.Connection = connection;

                connection.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }

            return expense;
        }

        public Expense GetExpense(int id)
        {
            using (connection = new SqlConnection(sqlDBPath))
            {
                SqlCommand cmd = new SqlCommand();

                SqlDataAdapter sda = new SqlDataAdapter("Select * FROM Expenses WHERE Id=" + id, connection);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                connection.Open();

                Expense expense = new Expense
                {
                    Id = dt.Rows[0].Field<int>("Id"),
                    Description = dt.Rows[0].Field<string>("Description"),
                    Amount = dt.Rows[0].Field<double>("Amount"),
                    UserId = dt.Rows[0].Field<int>("UserId")
                };

                connection.Close();

                return expense;
            }      
        }

        public List<Expense> GetExpenses()
        {
            using (connection = new SqlConnection(sqlDBPath))
            {
                List<Expense> expenses = new List<Expense>();

                SqlDataAdapter sda = new SqlDataAdapter("Select * FROM Expenses", connection);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                connection.Open();

                foreach (DataRow row in dt.Rows)
                {
                    Expense expense = new Expense
                    {
                        Id = row.Field<int>("Id"),
                        Description = row.Field<string>("Description"),
                        Amount = row.Field<double>("Amount"),
                        UserId = row.Field<int>("UserId")
                    };

                    expenses.Add(expense);
                }

                connection.Close();

                return expenses;
            }
        }
    }
}
