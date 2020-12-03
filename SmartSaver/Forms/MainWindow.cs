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
        delegate void MSG(string text);
        MSG msg = delegate (string text) { MessageBox.Show(text); };

        delegate string AddPrefix(Account account);
        AddPrefix addPref = delegate (Account account)
        {
            string prefix = "";
            if (account.gender == Gender.Male)
                prefix = "Mr. ";
            if (account.gender == Gender.Female)
                prefix = "Mrs. ";
            return prefix;
        };

        Account account;
        LoginWindow logWin = new LoginWindow();
        TitleWindow titleWindow;
        Settings settings;
        Spendings spendings;
        SQLInput sqlIn = new SQLInput();
        SQLExpensesList sqlExpensesList = new SQLExpensesList();
        SQLExpensesTypesList sqlExpTypesList = new SQLExpensesTypesList();
        private float monthlyExpenses;
        List<String> typesList = new List<string>();
        Theme theme;

        public MainWindow(LoginWindow logWin, Account account)
        {
            InitializeComponent();

            this.logWin = logWin;
            this.account = account;



            titleWindow = new TitleWindow();
            settings = new Settings(account, this);
            spendings = new Spendings(account, this);
            monthlyExpenses = sqlExpensesList.GetSumOfExpenses(account.UserId);
            monthlyExpLabel.Text = "Current expenses this month: €" + monthlyExpenses;
            ReloadData();

            theme = new Theme(account.themes);
            changeTheme(theme);
            openChildForm(titleWindow);
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
            //UpdateProgressBar();
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
            if(AddExpensePanel.Visible == true)
            {
                AddExpensePanel.Visible = false;
            }
            else
            {
                AddExpensePanel.BringToFront();
                RefreshTypesList(account.UserId);
                ShowAddExpenses();
            }
            
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
                activeForm.Hide();
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
                        msg("Incorrect Amount format");
                    }
                }
                else
                {
                    msg("Invalid number format. Try again");
                    AmountTextBox.Clear();
                }
            }
            else
            {
                msg("Fill In Empty Fields");
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
            if(SetALimitPanel.Visible == true)
            {
                SetALimitPanel.Visible = false;
            }
            else
            {
                SetALimitPanel.BringToFront();
                ShowSetAGoal();
            }
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

                        //LimitProgressBar.Maximum = account.Limit;

                        MonthlyGoalText();
                        LimitAmountTextBox.Clear();
                    }
                    catch (Exception)
                    {
                        msg("Incorrect Amount format");
                    }
                }
                else
                {
                    msg("Invalid number format. Try again");
                    LimitAmountTextBox.Clear();
                }
            }
            else
            {
                msg("Fill In Empty Fields");
            }
        }

        private void RefreshTypesList(int userId)
        {
            ExpensesComboBox.Items.Clear();
            typesList = sqlExpTypesList.GetExpensesTypes(userId);
            foreach (string item in typesList)
            {
                ExpensesComboBox.Items.Add(item);
            }

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

        private void loadGreetings()
        {
            DisplayNameLabel.Text = "Hello, " + addPref(account) + account.Name + "!";
        }

        public void changeTheme(Theme theme)
        {
            titleWindow.BackColor = theme.BackColorFirst;
            settings.BackColor = theme.BackColorFirst; // first51, 51, 76
            settings.usernameLabel.ForeColor = theme.ForeColor; //fore 240, 240, 240
            settings.CustomizeLabel.BackColor = theme.BackColorFirst;
            settings.ChangeNamePanel.BackColor = theme.BackColorSecond; // second153, 180, 209
            settings.ChangeThemeButton.BackColor = theme.BackColorSecond;
            settings.changeNameButton.BackColor = theme.BackColorSecond;
            settings.RemoveButton.BackColor = theme.BackColorSecond;
            settings.AddNewChoiceButton.BackColor = theme.BackColorSecond;
            spendings.BackColor = theme.BackColorFirst;
            spendings.dataGridView.BackgroundColor = theme.BackColorFirst;
            spendings.SpendingsChart.BackColor = theme.BackColorSecond;
            spendings.LimitProgressBar.InnerColor = theme.BackColorFirst;
            spendings.TipOfTheDay1.ForeColor = theme.ForeColor;
            this.BackColor = theme.BackColorFirst;
            this.lowerPanel.BackColor = theme.BackColorThree;  // third51, 51, 60
            this.MonthlyGoalLabel.ForeColor = theme.ForeColor;
            this.monthlyExpLabel.ForeColor = theme.ForeColor;
            this.panelMenu.BackColor = theme.BackColorSecond;
            this.logOutLabel.ForeColor = theme.ForeColor;
            this.spendingsButton.BackColor = theme.BackColorSecond;
            this.addExpensesButton.BackColor = theme.BackColorSecond;
            this.settingsBtn.BackColor = theme.BackColorSecond;
            this.exitBtn.BackColor = theme.BackColorSecond;
            this.setALimitButton.BackColor = theme.BackColorSecond;
            this.AddExpensePanel.BackColor = theme.BackColorSecond;
            this.SetALimitPanel.BackColor = theme.BackColorSecond;
            this.AddToExpensesButton.BackColor = theme.BackColorFirst;
            this.SetLimitAmountButton.BackColor = theme.BackColorFirst;
        }

        private void applicationName_Click(object sender, EventArgs e)
        {
            openChildForm(titleWindow);
        }
    }
}