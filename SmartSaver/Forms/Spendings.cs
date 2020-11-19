﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace SmartSaver.Forms
{
    public partial class Spendings : Form
    {

        //Used for chart
        Series SpendingsSeries;
        SQLExpensesList sqlExpensesList = new SQLExpensesList();
        Account account;
        private float monthlyExpenses;
        DataTable spSumByType;

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

            ReloadData();
        }

        public void ReloadData()
        {

            DataTable sTable = sqlExpensesList.GetExpenses(account.UserId);
            dataGridView1.DataSource = sTable;
            dataGridView1.ReadOnly = true;
            dataGridView1.Columns["Date"].Width = 120;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            monthlyExpenses = sqlExpensesList.GetSumOfExpenses(account.UserId);
            UpdateProgressBar();
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
            DataTable ExpencesTable = sqlExpensesList.GetExpenses(account.UserId);
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

    }
}
