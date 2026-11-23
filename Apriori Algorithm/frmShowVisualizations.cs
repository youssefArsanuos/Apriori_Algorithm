
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Apriori_Algorithm
{
    public partial class frmShowVisualizations : Form
    {
        private List<Dictionary<string, int>> FrequentLevels;
        private int TotalTransactions;

        public frmShowVisualizations(
            List<Dictionary<string, int>> frequentLevels,
            int totalTransactions)
        {
            InitializeComponent();

            FrequentLevels = frequentLevels;
            TotalTransactions = totalTransactions;
        }

        private void frmShowVisualizations_Load(object sender, EventArgs e)
        {
            Display_Support_Chart();
        }

        private void Display_Support_Chart()
        {
            chartSupport.Series.Clear();
            chartSupport.ChartAreas.Clear();

            if (TotalTransactions == 0)
                return;

            ChartArea chartArea = new ChartArea("SupportArea");

            chartArea.AxisX.Title = "Frequent Itemsets";
            chartArea.AxisY.Title = "Support (%)";
            chartArea.AxisY.Minimum = 0;
            chartArea.AxisY.Maximum = 100;
            chartArea.AxisY.Interval = 10;
            chartArea.AxisX.Interval = 1;
            chartArea.AxisX.LabelStyle.Angle = -45;

            chartSupport.ChartAreas.Add(chartArea);

            Series series = new Series("Support");
            series.ChartType = SeriesChartType.Column;
            series.IsValueShownAsLabel = true;
            series.LabelFormat = "0.##'%'";

            for (int i = 0; i < FrequentLevels.Count; i++)
            {
                foreach (KeyValuePair<string, int> itemset in FrequentLevels[i])
                {
                    double support =
                        (double)itemset.Value / TotalTransactions * 100;

                    series.Points.AddXY(itemset.Key, support);
                }
            }

            chartSupport.Series.Add(series);
        }
    }
}
