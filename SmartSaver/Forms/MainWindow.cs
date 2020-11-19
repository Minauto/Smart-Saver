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
        Settings settings;
        Spendings spendings;
        SQLInput sqlIn = new SQLInput();
        SQLExpensesList sqlExpensesList = new SQLExpensesList();
        SQLExpensesTypesList sqlExpTypesList = new SQLExpensesTypesList();
        private float monthlyExpenses;
        List<String> typesList = new List<string>();
        bool darkMode;


        public MainWindow(LoginWindow logWin, String username, String name, int userId, Gender gender, int limit)
        {
            InitializeComponent();

            this.logWin = logWin;
            account = new Account(username, name, userId, gender, limit);
            settings = new Settings(account, this);
            spendings = new Spendings(account, this);
            monthlyExpenses = sqlExpensesList.GetSumOfExpenses(userId);
            LimitProgressBar.Maximum = (int)account.Limit;
            monthlyExpLabel.Text = "Current expenses this month: €" + monthlyExpenses;
            this.darkMode = true;
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
            openChildForm(spendings);
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
            SetALimitPanel.Visible = false;

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

            monthlyExpenses = sqlExpensesList.GetSumOfExpenses(account.UserId);
            monthlyExpLabel.Text = "Current expenses this month: €" + monthlyExpenses;

            RefreshTypesList(account.UserId);

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
            SetALimitPanel.Visible = true;
        }

        private void ExitSetAGoalLabel_Click(object sender, EventArgs e)
        {
            SetALimitPanel.Visible = false;
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
            openChildForm(settings);
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

        private void loadGreetings()
        {
            String prefix = "";
            if (account.gender == Gender.Male)
                prefix = "Mr. ";
            if (account.gender == Gender.Female)
                prefix = "Mrs. ";
            DisplayNameLabel.Text = "Hello, " + prefix + account.Name + "!";
        }

        public void changeTheme()
        {
            if (this.darkMode)
            {
                settings.BackColor = Color.FromArgb(192, 192, 192);
                settings.usernameLabel.ForeColor = Color.FromArgb(0, 0, 0);
                settings.CustomizeLabel.BackColor = Color.FromArgb(192, 192, 192);
                settings.ChangeNamePanel.BackColor = Color.FromArgb(100, 100, 100);
                settings.ChangeThemeButton.BackColor = Color.FromArgb(100, 100, 100);
                settings.changeNameButton.BackColor = Color.FromArgb(100, 100, 100);
                settings.RemoveButton.BackColor = Color.FromArgb(100, 100, 100);
                settings.AddNewChoiceButton.BackColor = Color.FromArgb(100, 100, 100);
                spendings.BackColor = Color.FromArgb(192, 192, 192);
                spendings.dataGridView.BackgroundColor = Color.FromArgb(192, 192, 192);
                spendings.SpendingsChart.BackColor = Color.FromArgb(192, 192, 192);
                this.BackColor = Color.FromArgb(192, 192, 192);
                this.lowerPanel.BackColor = Color.FromArgb(255, 255, 255);
                this.MonthlyGoalLabel.ForeColor = Color.FromArgb(0, 0, 0);
                this.monthlyExpLabel.ForeColor = Color.FromArgb(0, 0, 0);
                this.LimitProgressBar.InnerColor = Color.FromArgb(192, 192, 192);
                this.panelMenu.BackColor = Color.FromArgb(134, 134, 134);
                this.logOutLabel.ForeColor = Color.FromArgb(0, 0, 0);
                this.spendingsButton.BackColor = Color.FromArgb(192, 192, 192);
                this.addExpensesButton.BackColor = Color.FromArgb(192, 192, 192);
                this.settingsBtn.BackColor = Color.FromArgb(192, 192, 192);
                this.exitBtn.BackColor = Color.FromArgb(192, 192, 192);
                this.setALimitButton.BackColor = Color.FromArgb(192, 192, 192);
                this.AddExpensePanel.BackColor = Color.FromArgb(100, 100, 100);
                this.SetALimitPanel.BackColor = Color.FromArgb(100, 100, 100);
                this.AddToExpensesButton.BackColor = Color.FromArgb(100, 100, 100);
                this.SetLimitAmountButton.BackColor = Color.FromArgb(100, 100, 100);
                darkMode = false;
            }
            else
            {
                settings.BackColor = Color.FromArgb(51, 51, 76);
                settings.usernameLabel.ForeColor = Color.FromArgb(240, 240, 240);
                settings.CustomizeLabel.BackColor = Color.FromArgb(51, 51, 76);
                settings.ChangeNamePanel.BackColor = Color.FromArgb(153, 180, 209);
                settings.ChangeThemeButton.BackColor = Color.FromArgb(153, 180, 209);
                settings.changeNameButton.BackColor = Color.FromArgb(153, 180, 209);
                settings.RemoveButton.BackColor = Color.FromArgb(153, 180, 209);
                settings.AddNewChoiceButton.BackColor = Color.FromArgb(153, 180, 209);
                spendings.BackColor = Color.FromArgb(51, 51, 76);
                spendings.dataGridView.BackgroundColor = Color.FromArgb(51, 51, 76);
                spendings.SpendingsChart.BackColor = Color.FromArgb(153, 180, 209);
                this.BackColor = Color.FromArgb(51, 51, 76);
                this.lowerPanel.BackColor = Color.FromArgb(51, 51, 60);
                this.MonthlyGoalLabel.ForeColor = Color.FromArgb(240, 240, 240);
                this.monthlyExpLabel.ForeColor = Color.FromArgb(240, 240, 240);
                this.LimitProgressBar.InnerColor = Color.FromArgb(51, 51, 76);
                this.panelMenu.BackColor = Color.FromArgb(153, 180, 209);
                this.logOutLabel.ForeColor = Color.FromArgb(240, 240, 240);
                this.spendingsButton.BackColor = Color.FromArgb(153, 180, 209);
                this.addExpensesButton.BackColor = Color.FromArgb(153, 180, 209);
                this.settingsBtn.BackColor = Color.FromArgb(153, 180, 209);
                this.exitBtn.BackColor = Color.FromArgb(153, 180, 209);
                this.setALimitButton.BackColor = Color.FromArgb(153, 180, 209);
                this.AddExpensePanel.BackColor = Color.FromArgb(153, 180, 209);
                this.SetALimitPanel.BackColor = Color.FromArgb(153, 180, 209);
                this.AddToExpensesButton.BackColor = Color.FromArgb(51, 51, 76);
                this.SetLimitAmountButton.BackColor = Color.FromArgb(51, 51, 76);
                darkMode = true;
            }
        }
    }
}