using DienMayXanh_Store.Charts;
using DienMayXanh_Store.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DienMayXanh_Store.Views.Dialogs
{
    public partial class FormStatistical : Form
    {
        private ContextDB context = Program.context;
        private string staffId;
        private List<double> revenue, totalBill;
        private List<string> date;
        private int month, year;
        public FormStatistical(string staffId)
        {
            InitializeComponent();
            this.staffId = staffId;
        }

        private void FormStatistical_Load(object sender, EventArgs e)
        {
            STAFF info = context.STAFFS.Find(staffId);
            var total = context.RECIEPTS.Where(x => x.StaffID.Equals(this.staffId));
            this.dtpMonth.MaxDate = DateTime.Now;
            this.lblTotalRevenue.Text = String.Format("{0:n0}", total.Sum(x => (decimal?)x.Total).GetValueOrDefault()) + " VNĐ";
            this.lblTotalBill.Text = String.Format("{0:n0}", total.Count());
            this.lblName.Text = info.Name;
            this.avatar.ImageLocation = @"..\..\Images\" + this.staffId + ".png";
            cmbFilter.SelectedIndex = 0;
            chart.ApplyConfig(ConfigChart.Config(), System.Drawing.Color.FromArgb(238, 238, 242));
            getCurrDate();
            loadData();
        }

        private void getCurrDate()
        {
            this.month = dtpMonth.Value.Month;
            this.year = dtpMonth.Value.Year;
        }

        private int getLastDate()
        {
            return DateTime.DaysInMonth(this.year, this.month);
        }

        private void loadData(bool type = true)
        {
            chart.Datasets.Clear();
            int startDate = 1, lastDate = getLastDate();
            List<RECIEPT> data = context.RECIEPTS
                .Where(staff => staff.StaffID.Equals(this.staffId) &&
                staff.CreateAt.Month == this.month && staff.CreateAt.Year == this.year)
                .ToList();

            this.date = new List<string>();
            if(type)
            {
                this.revenue = new List<double>();
                addData(data, this.revenue, type, startDate, lastDate);
                Line.loadChart(chart, this.revenue, this.date, "Doanh thu");
            }
            else
            {
                this.totalBill = new List<double>();
                addData(data, this.totalBill, type, startDate, lastDate);
                Line.loadChart(chart, this.totalBill, this.date, "Tổng đơn");
            }

        }

        private void addData(List<RECIEPT> reciept, List<double> data,
            bool type, int start, int end)
        {
            double total = 0;
            while(start <= end)
            {
                this.date.Add(start.ToString());
                if(type)
                    total = (double)reciept.Where(item => item.CreateAt.Day == start).Sum(x => x.Total);
                else total = reciept.Where(item => item.CreateAt.Day == start).Count();

                data.Add(total);
                start++;
            }
        }

        private void cmbFilter_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cmbFilter.SelectedIndex == 0)
                loadData();
            else
                loadData(false);
        }

        private void dtpMonth_ValueChanged(object sender, EventArgs e)
        {
            getCurrDate();
            loadData();
        }
    }
}
