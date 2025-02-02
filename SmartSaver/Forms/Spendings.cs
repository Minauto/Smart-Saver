﻿using SharedProject.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Threading;
using Newtonsoft.Json;

namespace Saver.Forms
{
    public partial class Spendings : Form
    {

        //Used for chart
        Series SpendingsSeries;
        SQLExpensesList sqlExpensesList = new SQLExpensesList();
        Account account;
        private float monthlyExpenses;
        DataTable spSumByType;
        TipsManager TM = new TipsManager();
        //Label TipOfTheDay = new Label();
        Func<int, DataTable> getExpenses;
        DataTable sTable;

        MainWindow mw;
        //RestClient rClient = new RestClient();

        public Spendings(Account account, MainWindow mainWindow)
        {
            InitializeComponent();

            this.account = account;
            spSumByType = sqlExpensesList.GetExpensesSumByType(account.UserId);

            SpendingsSeries = new Series();

            SpendingsSeries.Name = @"Spendings";
            SpendingsChart.Series.Add(SpendingsSeries);
            SpendingsSeries.ChartType = SeriesChartType.Column;
            LimitProgressBar.Maximum = (int)account.Limit;

            getExpenses = (userId) => sqlExpensesList.GetExpenses(userId);

            ReloadData();

            mw = mainWindow;
            mw.ExpensesAdded += ExpensesAdded;
        }
        void ExpensesAdded(object sender, EventArgs e)
        {
            ReloadData();
        }

        /*private async void getExpensesAsync(int id)
        {

            string strResponse;
            rClient.resetEndpoint();
            rClient.endPoint += "/data/"+id;

            Task<string> result = rClient.makeRequest();

            strResponse = await result;

            sTable = JsonConvert.DeserializeObject<DataTable>(strResponse);
        }*/

        public void ReloadData()
        {
            
            //getExpensesAsync(account.UserId);
            sTable = getExpenses(account.UserId);
            dataGridView.DataSource = sTable;
            dataGridView.ReadOnly = true;
            dataGridView.Columns["Date"].Width = 120;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            monthlyExpenses = sqlExpensesList.GetSumOfExpenses(account.UserId);

            UpdateProgressBar();
            LoadTips();
            loadChart();
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
            DataTable ExpencesTable = getExpenses(account.UserId);
            List <Expences> ExpencesList = new List<Expences>();
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

        private void LoadTips()
        {
            Expences TipOnExpences = TM.GetTips(account.UserId);
            TipOfTheDay1.Text = "You should maybe think about cutting expences on " + TipOnExpences.ExpencesType + "\n" + "You already spent " + TipOnExpences.ExpencesF + " on it";
        }

        public void OnDataAdded (object source, EventArgs e)
        {
            ReloadData();
        }
    }
}
