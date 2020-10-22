using System;
using System.Data;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace SmartSaver
{
    public partial class MainWindow : Form
    {
        Account account;
        LoginWindow logWin = new LoginWindow();
        SQLInput sqlIn = new SQLInput();
        SQLExpensesList sqlExpensesList = new SQLExpensesList();
        private String monthlyExpenses;
        

        public MainWindow(LoginWindow logWin, String username, String name, String surname, int userId)
        {
            InitializeComponent();
            this.logWin = logWin;
            account = new Account(username, name, surname, userId);
            monthlyExpenses = Convert.ToString(sqlExpensesList.GetSumOfExpenses(userId));

            MonthlyGoalText();
            DisplayNameLabel.Text = "Hello, " + name + "!";
            monthlyExpLabel.Text = "Current expenses this month: €" + monthlyExpenses;
        }

        private void MonthlyGoalText ()
        {
            if (account.GoalSet)
            {
                if (account.Goal > 0)
                {
                    MonthlyGoalLabel.Text = "Remaining money to spend this month: €" + account.Goal;
                }
                else
                {
                    MonthlyGoalLabel.Text = "Goal reached";
                }
            }
            else
            {
                MonthlyGoalLabel.Text = "No goal set yet.";
            }
        }
        private void SpendingsButton_Click(object sender, EventArgs e)
        {
            HideAll();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AddExpensesButton_Click(object sender, EventArgs e)
        {
            HideAll();
            ShowAddExpenses();
        }
        private void ExitAddExpensesLabel_Click(object sender, EventArgs e)
        {
            AddExpensePanel.Visible = false;
        }


        private void ShowAddExpenses()
        {
            AddExpensePanel.Visible = true;
        }

        private void HideAll()
        {
            AddExpensePanel.Visible = false;
            SetAGoalPanel.Visible = false;
        }

        private void AddToExpensesButton_Click(object sender, EventArgs e)
        {

            if (AmountTextBox.Text != "" & ExpensesComboBox.Text != "")
            {
                Regex regex = new Regex(@"^(?!(?:0|0\.0|0\.00)$)[+]?\d+(\.\d|\.\d[0-9])?$"); // Accepts only positive numbers, up to 2 decimal places

                if (regex.IsMatch(AmountTextBox.Text))
                {
                    try
                    {
                        sqlIn.CreateEpenses(account.UserId, float.Parse(AmountTextBox.Text), ExpensesComboBox.Text, DateTime.Now);
                        account.updateGoal(int.Parse(AmountTextBox.Text));
                        MonthlyGoalText();
                        AmountTextBox.Clear();
                        ExpensesComboBox.Text = "";
                        ReloadData();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Incorrect Amount format");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid number format. Try again");
                    AmountTextBox.Clear();
                }
            }
            else
            {
                MessageBox.Show("Fill In Empty Fields");
            }
            

        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            ReloadData();
        }

        private void ReloadData()
        {

            DataTable sTable = sqlExpensesList.GetExpenses(account.UserId);

            dataGridView1.DataSource = sTable;
            dataGridView1.ReadOnly = true;
            dataGridView1.Columns["Date"].Width = 120;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            monthlyExpenses = Convert.ToString(sqlExpensesList.GetSumOfExpenses(account.UserId));
            monthlyExpLabel.Text = "Current expenses this month: €" + monthlyExpenses;
        }

        private void logOutLabel_Click(object sender, EventArgs e)
        {
            this.Close();
            logWin.Show();
        }

        private void setAGoalButton_Click(object sender, EventArgs e)
        {
            HideAll();
            ShowSetAGoal();
        }

        private void ShowSetAGoal ()
        {
            SetAGoalPanel.Visible = true;
        }

        private void ExitSetAGoalLabel_Click(object sender, EventArgs e)
        {
            SetAGoalPanel.Visible = false;
        }

        private void SetGoalAmountButton_Click(object sender, EventArgs e)
        {
            if (GoalAmountTextBox.Text != "")
            {
                Regex regex = new Regex(@"^(?!(?:0|0\.0|0\.00)$)[+]?\d+(\.\d|\.\d[0-9])?$"); // Accepts only positive numbers, up to 2 decimal places

                if (regex.IsMatch(GoalAmountTextBox.Text))
                {
                    try
                    {
                        account.Goal = int.Parse(GoalAmountTextBox.Text);
                        account.GoalSet = true;
                        MessageBox.Show("Goal set");
                        MonthlyGoalText();
                        GoalAmountTextBox.Clear();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Incorrect Amount format");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid number format. Try again");
                    GoalAmountTextBox.Clear();
                }
            }
            else
            {
                MessageBox.Show("Fill In Empty Fields");
            }
        }
    }
    }

