using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DienMayXanh_Store.Report
{
    public partial class PrintReports : Form
    {
        public PrintReports()
        {
            InitializeComponent();
        }

        public void printExportBill(string exportID)
        {
            ExportsProducts report = new ExportsProducts();
            foreach (DevExpress.XtraReports.Parameters.Parameter p in report.Parameters)
            {
                p.Visible = false;
            }
            report.setRecieptID(exportID);
            documentViewer1.DocumentSource = report;
            report.CreateDocument();
        }
        public void printImportBill(string importID)
        {
            ImportProducts report = new ImportProducts();
            foreach (DevExpress.XtraReports.Parameters.Parameter p in report.Parameters)
            {
                p.Visible = false;
            }
            report.setImportID(importID);
            documentViewer1.DocumentSource = report;
            report.CreateDocument();
        }
        public void printInvoice(string recieptID)
        {
            CustomerInvoice report = new CustomerInvoice();
            foreach (DevExpress.XtraReports.Parameters.Parameter p in report.Parameters)
            {
                p.Visible = false;
            }
            report.setInvoiceID(recieptID);
            documentViewer1.DocumentSource = report;
            report.CreateDocument();
        }
        public void printListStaff()
        {
            ListStaff report = new ListStaff();
            foreach (DevExpress.XtraReports.Parameters.Parameter p in report.Parameters)
            {
                p.Visible = false;
            }
            documentViewer1.DocumentSource = report;
            report.CreateDocument();
        }
    }
}
