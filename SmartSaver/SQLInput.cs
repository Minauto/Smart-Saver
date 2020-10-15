using System;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.IO;
using System.Windows.Forms;

namespace SmartSaver
{
    class SQLInput
    {

        static string workingDirectory = Environment.CurrentDirectory;
        static string sourcePath = Directory.GetParent(workingDirectory).Parent.FullName + @"\Database2.mdf";
        //sourcePath = sourcePath + @"\Database2.mdf";

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + sourcePath + ";Integrated Security=True");

        public bool CreateAccount (string username, string password, string name, string surname)
        {
            

            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) From Account where Username='" + username + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows[0][0].ToString() == "0")
            {

                System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
                cmd.CommandType = System.Data.CommandType.Text;

                HashSalt hashSalt = HashSalt.GenerateSaltedHash(16, password);
                //Console.WriteLine(hashSalt.Hash + " " + hashSalt.Salt);

                cmd.CommandText = "INSERT Account  (Username, Password, Name, Surname, Hash, Salt) VALUES ('" + username + "', '" + password + "', '" + name + "', '" + surname + "', '" + hashSalt.Hash + "', '" + hashSalt.Salt + "')";  //SQL sentences
                cmd.Connection = con;

                con.Open();

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Account created");
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc + "Failed to connect to SQL server");
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

        public void CreateEpenses(int UserId, float Expenses, String ExpensesType, DateTime Date)
        {
            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;

            DateTime dt = Date;
            try
            {
                dt = DateTime.ParseExact("" + Date + "", "MM/dd/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
                dt.ToString("dd/MM/yyyy hh:mm:ss");
            }catch(Exception)
            {
            }
            
            cmd.CommandText = "INSERT ExpensesData  (UserId, Expenses, ExpensesType, Date) VALUES ('" + UserId + "', '" + Expenses + "', '" + ExpensesType + "', '" + dt + "')";
            cmd.Connection = con;

            con.Open();

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Expenses Registered");
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc + "Failed to connect to SQL server");
            }
            con.Close();

        }
    }
}
