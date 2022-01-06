using Guna.Charts.WinForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DienMayXanh_Store.Charts
{
    class Line
    {
        public static void loadChart(Guna.Charts.WinForms.GunaChart chart, List<double> data, List<string> date, string label)
        {
            chart.YAxes.GridLines.Display = false;

            var datasetRevenue = new GunaLineDataset();
            datasetRevenue.PointRadius = 3;
            datasetRevenue.FillColor = Color.White;
            datasetRevenue.BorderColor = Color.FromArgb(242, 153, 74);
            datasetRevenue.Label = label;
            datasetRevenue.PointStyle = PointStyle.Circle;

            for (int i = 0; i < date.Count; i++)
                datasetRevenue.DataPoints.Add(date[i], (double)data[i]);
            chart.Datasets.Add(datasetRevenue);
            //An update was made to re-render the chart
            chart.Update();
        }
    }
}
