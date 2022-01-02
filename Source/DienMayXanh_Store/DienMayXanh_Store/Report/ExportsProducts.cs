using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace DienMayXanh_Store.Report
{
    public partial class ExportsProducts : DevExpress.XtraReports.UI.XtraReport
    {
        public ExportsProducts()
        {
            InitializeComponent();
        }
        public void setRecieptID(string exportID)
        {
            pRecieptID.Value = exportID;
        }
    }
}
