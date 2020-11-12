using CustomExtensions;
using SmartSaver.Forms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace SmartSaver
{
    public partial class MainWindow : Form
    {
        Account account;
        LoginWindow logWin = new LoginWindow();
        SQLInput sqlIn = new SQLInput();
        SQLExpensesList sqlExpensesList = new SQLExpensesList();
        SQLExpensesTypesList sqlExpTypesList = new SQLExpensesTypesList();
        private float monthlyExpenses;
        List<String> typesList = new List<string>();

        //Used for chart
        Series SpendingsSeries;

        public MainWindow(LoginWindow logWin, String username, String name, int userId, Gender gender, int limit)
        {
            InitializeComponent();

            SpendingsSeries = new Series();
            this.logWin = logWin;
            account = new Account(username, name, userId, gender, limit);

            monthlyExpenses = sqlExpensesList.GetSumOfExpenses(userId);
            LimitProgressBar.Maximum = (int)account.Limit;
            monthlyExpLabel.Text = "Current expenses this month: €" + monthlyExpenses;

            SpendingsSeries.Name = @"Spendings";
            SpendingsChart.Series.Add(SpendingsSeries);
            SpendingsSeries.ChartType = SeriesChartType.Column;
            ReloadData();
        }

        private void MonthlyGoalText()
        {
            if (account.Limit > 0)
            {
                if (account.Limit - monthlyExpenses > 0)
                {
                    MonthlyGoalLabel.Text = "Remaining money to spend this month: €" + (account.Limit - monthlyExpenses);
                }
                else
                {
                    MonthlyGoalLabel.Text = "Limit reached";
                }
            }
            else
            {
                MonthlyGoalLabel.Text = "Limit not set";
            }
            UpdateProgressBar();
        }
        private void SpendingsButton_Click(object sender, EventArgs e)
        {
            HideAll();
            dataGridView1.Show();
            SpendingsChart.Visible = true;

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AddExpensesButton_Click(object sender, EventArgs e)
        {
            HideAll();
            RefreshTypesList(account.UserId);
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
            if (activeForm != null)
            {
                activeForm.Close();
            }
            AddExpensePanel.Visible = false;
            SetAGoalPanel.Visible = false;
            dataGridView1.Hide();

            //SpendingsChart hidden with others
            SpendingsChart.Visible = false;
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
                        sqlIn.CreateExpenses(account.UserId, float.Parse(AmountTextBox.Text), ExpensesComboBox.Text, DateTime.Now);
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

        }

        public void ReloadData()
        {

            DataTable sTable = sqlExpensesList.GetExpenses(account.UserId);

            dataGridView1.DataSource = sTable;
            dataGridView1.ReadOnly = true;
            dataGridView1.Columns["Date"].Width = 120;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            monthlyExpenses = sqlExpensesList.GetSumOfExpenses(account.UserId);
            monthlyExpLabel.Text = "Current expenses this month: €" + monthlyExpenses;

            RefreshTypesList(account.UserId);

            loadChart();

            MonthlyGoalText();

            loadGreetings();
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

        private void ShowSetAGoal()
        {
            SetAGoalPanel.Visible = true;
        }

        private void ExitSetAGoalLabel_Click(object sender, EventArgs e)
        {
            SetAGoalPanel.Visible = false;
        }

        private void SetLimitAmountButton_Click(object sender, EventArgs e)
        {
            if (LimitAmountTextBox.Text != "")
            {
                Regex regex = new Regex(@"^(?!(?:0|0\.0|0\.00)$)[+]?\d+(\.\d|\.\d[0-9])?$"); // Accepts only positive numbers, up to 2 decimal places

                if (regex.IsMatch(LimitAmountTextBox.Text))
                {
                    try
                    {
                        account.Limit = int.Parse(LimitAmountTextBox.Text);
                        sqlIn.AddLimit(account.UserId, account.Limit);

                        LimitProgressBar.Maximum = account.Limit;

                        MonthlyGoalText();
                        LimitAmountTextBox.Clear();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Incorrect Amount format");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid number format. Try again");
                    LimitAmountTextBox.Clear();
                }
            }
            else
            {
                MessageBox.Show("Fill In Empty Fields");
            }
        }

        private void RefreshTypesList(int userId)
        {
            ExpensesComboBox.Items.Clear();
            typesList = sqlExpTypesList.GetExpensesTypes(userId);
            ExpensesComboBox = typesList.ToComboBox(ExpensesComboBox);
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            HideAll();

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            MainPanel.Controls.Add(childForm);
            MainPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void settingsBtn_Click(object sender, EventArgs e)
        {
            openChildForm(new Settings(account, this));
        }

        private void UpdateProgressBar()
        {
            if (account.Limit >= (int)monthlyExpenses)
            {
                LimitProgressBar.Value = (int)monthlyExpenses;
                LimitProgressBar.OuterColor = Color.Gray;
            }
            else
            {
                LimitProgressBar.Value = LimitProgressBar.Maximum;
                LimitProgressBar.OuterColor = Color.FromArgb(255, 0, 0);
            }
        }

        private void loadChart()
        {
            SpendingsSeries.Points.Clear();
            DataTable ExpencesTable = sqlExpensesList.GetExpenses(account.UserId);

            List<Expences> ExpencesList = new List<Expences>();
            ExpencesList = (from DataRow dr in ExpencesTable.Rows
                            select new Expences()
                            {
                                ExpencesF = Convert.ToDecimal(dr["Expenses"]),
                                ExpencesType = dr["ExpensesType"].ToString(),
                                Date = Convert.ToDateTime(dr["Date"]),
                            }).ToList();

            var ExpencesTypes = ExpencesList.Select(e => e.ExpencesType).Distinct().ToList();

            int x = 0;

            SpendingsChart.Series.Clear();

            foreach (var Expence in ExpencesTypes)
            {
                SpendingsChart.Series.Add(Expence);

                var SumOfExpence = ExpencesList.Where(e => e.ExpencesType == Expence).Sum(e => e.ExpencesF);
                SpendingsChart.Series[Expence].Points.AddXY(ExpencesTypes[x], SumOfExpence);

                x++;
            }
            SpendingsChart.AlignDataPointsByAxisLabel();
            SpendingsChart.ChartAreas[0].AxisX.LabelStyle.Angle = 90;
            SpendingsChart.ChartAreas[0].AxisX.IsLabelAutoFit = false;

        }

        private void loadGreetings()
        {
            String prefix = "";
            if (account.gender == Gender.Male)
                prefix = "Mr. ";
            if (account.gender == Gender.Female)
                prefix = "Mrs. ";
            DisplayNameLabel.Text = "Hello, " + prefix + account.Name + "!";
        }

    }
}