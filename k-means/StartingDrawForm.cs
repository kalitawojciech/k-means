using System.Collections.Generic;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace k_srednich
{
    public partial class StartingDrawForm : Form
    {
        //private double[][] _uploadedData;
        private List<MyPoint> _uploadedData;

        public StartingDrawForm(List<MyPoint> uploadedData)
        {
            _uploadedData = uploadedData;
            InitializeComponent();
            ClearChart();
            DrawStartingChart();
        }

        private void ClearChart()
        {
            startingDataChart.Series.Clear();
        }

        public void DrawStartingChart()
        {
            startingDataChart.Series.Clear();
            startingDataChart.ChartAreas.Clear();
            startingDataChart.Legends.Clear();

            startingDataChart.ChartAreas.Add(new ChartArea(Name = "StartedChart"));

            Legend legend = new Legend();
            legend.Name = "Legend";
            startingDataChart.Legends.Add(legend);

            Series serie = new Series
            {
                ChartType = 0,
                MarkerSize = 10,
                Name = "Starting chart serie"
            };

            foreach(MyPoint point in _uploadedData)
            {
                serie.Points.AddXY(point.X, point.Y);
            }

            startingDataChart.Series.Add(serie);
        }
    }
}
