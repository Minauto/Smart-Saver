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
        private static string sqlDBPath = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=SmartSaverDB;Integrated Security=True;";
        private SqlConnection connection = new SqlConnection(sqlDBPath);

        public ExpensesServices (AppDbContext context)
        {
            _context = context;
        }

        private void RefreshEntities ()
        {
            foreach (var entity in _context.ChangeTracker.Entries())
            {
                entity.Reload();
            }
        }

        public Expense CreateExpense(Expense expense)
        {
            SqlCommand cmd = new SqlCommand();

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO Expenses (Description, Amount, UserId) VALUES (" + "'" + expense.Description + "', " + expense.Amount + ", " + expense.UserId + ")";
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
                RefreshEntities();
            }

            return expense;

        }

        public void DeleteExpense(Expense expense)
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
                RefreshEntities();
            }
        }

        public Expense EditExpense(Expense expense)
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

            return expense;
        }

        public Expense GetExpense(int id)
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

        public List<Expense> GetExpenses()
        {
            List<Expense> expenses = new List<Expense>();

            SqlDataAdapter sda = new SqlDataAdapter("Select * FROM Expenses", connection);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            connection.Open();

            foreach (DataRow row in dt.Rows) {
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

        public List<Expense> GetExpensesList()
        {

            List<Expense> result = new List<Expense>();

            SqlDataAdapter sdaExpences = new SqlDataAdapter("Select * FROM Expenses", connection);
            DataTable dtExpences = new DataTable();
            sdaExpences.Fill(dtExpences);

            foreach (DataRow row in dtExpences.Rows)
            {
                Expense expense = new Expense
                {
                    Id = row.Field<int>("Id"),
                    Description = row.Field<string>("Description"),
                    Amount = row.Field<double>("Amount"),
                    UserId = row.Field<int>("UserId")
                };

                result.Add(expense);
            }



            return result;
        }



    }
}
