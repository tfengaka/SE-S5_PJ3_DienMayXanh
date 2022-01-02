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
    public partial class InvoiceDetail : Form
    {
        private ContextDB context = Program.context;
        private List<object> listProduct = new List<object>();
        private RECIEPT reciept;
        private string exportBillID = String.Empty;
        public InvoiceDetail()
        {
            InitializeComponent();
        }
        public InvoiceDetail(RECIEPT reciept ,List<object> cart, string exportID)
        {
            InitializeComponent();
            listProduct = cart;
            this.reciept = reciept;
            exportBillID = exportID;
        }
        private void InvoiceDetail_Load(object sender, EventArgs e)
        {
            dgv_listProduct.DataSource = listProduct;
            CUSTOMER customer = context.CUSTOMERS.Find(reciept.CustomerID);
            STAFF staff = context.STAFFS.Find(reciept.StaffID);
            lb_customerName.Text = customer.Name;
            lb_customerAddress.Text = customer.Address;
            lb_customerPhone.Text = customer.Phone;
            lb_recieptID.Text = reciept.RecieptID;
            lb_staffName.Text = staff.Name;
            lb_payMethod.Text = reciept.PaymentMethod;
            lb_recieptCreatAt.Text = reciept.CreateAt.ToString();
            lb_recieptTotal.Text = String.Format("{0:n0}", reciept.Total) + " VNĐ"; ;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_printInvoice_Click(object sender, EventArgs e)
        {
            Report.PrintReports report = new Report.PrintReports();
            report.printInvoice(reciept.RecieptID);
            report.Show();
        }

        private void btn_printExportBill_Click(object sender, EventArgs e)
        {
            Report.PrintReports report = new Report.PrintReports();
            report.printExportBill(exportBillID);
            report.Show();
        }
    }
}
