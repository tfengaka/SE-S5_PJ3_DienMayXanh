using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace DienMayXanh_Store.Report
{
    public partial class ImportProducts : DevExpress.XtraReports.UI.XtraReport
    {
        public ImportProducts()
        {
            InitializeComponent();
        }
        public void setImportID(string importID)
        {
            p_importID.Value = importID;
        }

    }
}
