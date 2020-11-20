using SharedProject.Utility;
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

namespace SmartSaver.Forms
{
    public partial class Spendings : Form
    {

        //Used for chart
        Series SpendingsSeries;
        SQLExpensesList sqlExpensesList = new SQLExpensesList();
        Account account;
        DataTable spSumByType;
        TipsManager TM = new TipsManager();
        //Label TipOfTheDay = new Label();



        public Spendings(Account account, MainWindow mainWindow)
        {
            InitializeComponent();

            this.account = account;
            spSumByType = sqlExpensesList.GetExpensesSumByType(account.UserId);

            SpendingsSeries = new Series();

            SpendingsSeries.Name = @"Spendings";
            SpendingsChart.Series.Add(SpendingsSeries);
            SpendingsSeries.ChartType = SeriesChartType.Column;

            ReloadData();
        }

        public void ReloadData()
        {

            DataTable sTable = sqlExpensesList.GetExpenses(account.UserId);
            dataGridView1.DataSource = sTable;
            dataGridView1.ReadOnly = true;
            dataGridView1.Columns["Date"].Width = 120;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;


            LoadTips();
            loadChart();
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

        private void LoadTips()
        {
            Expences TipOnExpences = TM.GetTips(account.UserId);
            TipOfTheDay1.Text = "You should maybe think about cutting expences on " + TipOnExpences.ExpencesType + "\n" + "You already spent " + TipOnExpences.ExpencesF + " on it";
        }

    }
}
