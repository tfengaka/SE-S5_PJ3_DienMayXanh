using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DienMayXanh_Store.Charts
{
    class Bar
    {
        public static void loadChart(Guna.Charts.WinForms.GunaChart chart, List<decimal> data)
        {
            //Chart configuration 
            chart.YAxes.GridLines.Display = false;
            List<string> month = new List<string>();
            int index = 12;
            while (index >= 1)
                month.Add(DateTime.Now.AddMonths(-index--).Month.ToString());

            //Create a new dataset 
            var dataset = new Guna.Charts.WinForms.GunaBarDataset();
            dataset.Label = "Lợi nhuận";
            for (int i = 0; i < month.Count; i++)
                dataset.DataPoints.Add(month[i], (double)data[i]);

            //Add a new dataset to a chart.Datasets
            chart.Datasets.Add(dataset);

            //An update was made to re-render the chart
            chart.Update();
        }
    }
}
