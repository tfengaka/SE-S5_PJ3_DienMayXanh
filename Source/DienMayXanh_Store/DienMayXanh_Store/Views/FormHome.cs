using DienMayXanh_Store.Charts;
using DienMayXanh_Store.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DienMayXanh_Store.Views
{
    public partial class FormHome : Form
    {
        private ContextDB context = Program.context;
        private List<decimal> revenue, profit;
        public FormHome()
        {
            InitializeComponent();
        }

        private void FormHome_Load(object sender, EventArgs e)
        {
            chart.Datasets.Clear();
            chartBar.Datasets.Clear();
            chart.ApplyConfig(ConfigChart.Config(), System.Drawing.Color.FromArgb(25, 26, 31));
            chartBar.ApplyConfig(ConfigChart.Config(), System.Drawing.Color.FromArgb(25, 26, 31));
            loadData();
        }

        private void loadData()
        {
            this.revenue = new List<decimal>();
            this.profit = new List<decimal>();
            decimal? money = 0, totalSpendInMonth = 0, totalProfit = 0;
            DateTime startDate;
            int day = 30, month = 12, currMonth = 0, currYear = DateTime.Now.Year;

            // revenue
            var revenue = context.RECIEPTS;
            while (day >= 0)
            {
                startDate = DateTime.Today.AddDays(-day--).Date;
                money = (decimal?)revenue
                    .Where(x => DbFunctions.TruncateTime(x.CreateAt) == startDate)
                    .Sum(x => (decimal?)x.Total).GetValueOrDefault();
                this.revenue.Add((decimal)money);          
                
            }

            // profit
            var spend = context.IESLIPS;
            while(month >= 1)
            {
                currMonth = DateTime.Now.AddMonths(-month--).Month;
                totalSpendInMonth = (decimal?)spend.Where(x =>
                x.CreateAt.Month == currMonth && x.CreateAt.Year == currYear
                && x.IESlipID.StartsWith("I"))
                    .Sum(x => (decimal?)x.TotalPrice).GetValueOrDefault();

                money = (decimal?)revenue.Where(x => x.CreateAt.Month == currMonth
                && x.CreateAt.Year == currYear)
                    .Sum(x => (decimal?)x.Total).GetValueOrDefault();
                totalProfit = money - totalSpendInMonth;
                this.profit.Add((decimal)totalProfit);
            }

            Line.loadChart(chart, this.revenue);
            Bar.loadChart(chartBar, this.profit);
        }
    }
}
