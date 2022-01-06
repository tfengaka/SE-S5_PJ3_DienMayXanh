using Guna.Charts.WinForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DienMayXanh_Store.Charts
{
    class LineDuplicate
    {
        public static void loadChart(Guna.Charts.WinForms.GunaChart chart, List<decimal> revenue , List<decimal> profit)
        {
            List<string> date = new List<string>();
            int index = 30;
            while (index >= 0)
                date.Add(DateTime.Today.AddDays(-index--).Date.ToString("dd/MM"));

            //Chart configuration 
            chart.YAxes.GridLines.Display = false;

            //Create a new dataset 
            var datasetRevenue = new GunaLineDataset();
            datasetRevenue.PointRadius = 3;
            datasetRevenue.FillColor = Color.FromArgb(242, 153, 74);
            datasetRevenue.BorderColor = Color.FromArgb(242, 153, 74);
            datasetRevenue.Label = "Doanh thu";
            datasetRevenue.PointStyle = PointStyle.Circle;
            var r = new Random();
            for (int i = 0; i < date.Count; i++)
                datasetRevenue.DataPoints.Add(date[i], (double)revenue[i]);
            var datasetProfit = new GunaLineDataset();
            datasetProfit.PointRadius = 3;
            datasetProfit.FillColor = Color.FromArgb(51, 200, 99);
            datasetProfit.BorderColor = Color.FromArgb(51, 200, 99);
            datasetProfit.Label = "Doanh số";
            datasetProfit.PointStyle = PointStyle.Circle;
            for (int i = 0; i < date.Count; i++)
                datasetProfit.DataPoints.Add(date[i], (double)profit[i]);


            //Add a new dataset to a chart.Datasets
            chart.Datasets.Add(datasetRevenue);
            chart.Datasets.Add(datasetProfit);
            //An update was made to re-render the chart
            chart.Update();
        }
    }
}
