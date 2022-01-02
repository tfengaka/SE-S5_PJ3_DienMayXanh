using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace DienMayXanh_Store.Report
{
    public partial class CustomerInvoice : DevExpress.XtraReports.UI.XtraReport
    {
        public CustomerInvoice()
        {
            InitializeComponent();
        }
        public void setInvoiceID(string recieptID)
        {
            p_recieptID.Value = recieptID;
        }
    }
}
