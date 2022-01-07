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
            chart.ApplyConfig(ConfigChart.Config(), System.Drawing.Color.FromArgb(238, 238, 242));
            loadData();
            initLoad();

        }

        private decimal getTotalIeslip()
        {
            decimal total = 0;
            var ieslips = context.IESLIPS.ToList();
            ieslips.ForEach(item => total += item.TotalPrice);
            return total;
        }
        private void initLoad()
        {
            var orders = (from reciept in context.RECIEPTS
                          join customer in context.CUSTOMERS on reciept.CustomerID equals customer.CustomerID
                          join staff in context.STAFFS on reciept.StaffID equals staff.StaffID
                          select new
                          {
                              reciept.RecieptID,
                              CustomerName = customer.Name,
                              reciept.CreateAt,
                              StaffName = staff.Name,
                              TotalPrice = reciept.Total
                          }).AsEnumerable().Select((item, index) => new
                          {
                              No = ++index,
                              item.RecieptID,
                              item.CustomerName,
                              item.StaffName,
                              item.CreateAt,
                              item.TotalPrice,
                          }).ToList();
            dgv_fullOrder.DataSource = orders;
            var carts = context.CARTITEMS.ToList();
            decimal totalProfit = 0;
            decimal totalSales = 0;
            orders.ForEach(o => totalProfit += o.TotalPrice);
            carts.ForEach(item => totalSales += item.Quantity);
            decimal totalCosts = context.IESLIPS
                .Where(x => x.IESlipID.StartsWith("I"))
                .Sum(x => x.TotalPrice);

            lb_totalSales.Text = totalSales + " Sản Phẩm";
            lb_totalProfit.Text = String.Format("{0:n0}", totalProfit) + " VNĐ";
            lb_totalCost.Text = String.Format("{0:n0}", totalCosts) + " VNĐ";
        }

        private void btn_detail_click(object sender, DataGridViewCellEventArgs e)
        {
            var dataGridView = (DataGridView)sender;
            if (dataGridView.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                string recieptID = dataGridView.Rows[e.RowIndex].Cells["RecieptID"].Value.ToString();
                var reciept = context.RECIEPTS.Find(recieptID);
                var cartitems = context.CARTITEMS.Where(item => item.RecieptID == recieptID).ToList();

                List<object> listItem = new List<object>();
                int index = 0;
                cartitems.ForEach(item =>
                {
                    PRODUCT product = context.PRODUCTS.Find(item.ProductID);
                    object cartitem = new
                    {
                        No = ++index,
                        ProductID = item.ProductID,
                        ProductName = product.Name,
                        Quantity = item.Quantity,
                        UnitPrice = product.Price,
                        Subtotal = item.SubTotal
                    };
                    listItem.Add(cartitem);
                });

                Dialogs.InvoiceDetail dialog = new Dialogs.InvoiceDetail(reciept, listItem, recieptID);
                dialog.ShowDialog();
            }

        }

        private void loadData()
        {
            chart.Datasets.Clear();
            this.revenue = new List<decimal>();
            this.profit = new List<decimal>();
            decimal? money = 0, totalProfitInDate = 0, totalProfit = 0;
            DateTime startDate;
            int day = 30;

            // revenue
            var revenue = context.RECIEPTS;
            var spend = context.IESLIPS.Where(x => x.IESlipID.StartsWith("I"));
            while (day >= 0)
            {
                startDate = DateTime.Today.AddDays(-day--).Date;
                money = (decimal?)revenue
                    .Where(x => DbFunctions.TruncateTime(x.CreateAt) == startDate)
                    .Sum(x => (decimal?)x.Total).GetValueOrDefault();
                this.revenue.Add((decimal)money);

                totalProfitInDate = (decimal?)spend.Where(x =>
                DbFunctions.TruncateTime(x.CreateAt) == startDate)
                   .Sum(x => (decimal?)x.TotalPrice).GetValueOrDefault();
              
                totalProfit = money - totalProfitInDate;
                this.profit.Add((decimal)totalProfit);
            }

            LineDuplicate.loadChart(chart, this.revenue, this.profit);
        }
    }
}
