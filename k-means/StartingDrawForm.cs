using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace k_srednich
{
    public partial class StartingDrawForm : Form
    {
        private double[][] _uploadedData;

        public StartingDrawForm(double[][] uploadedData)
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

            startingDataChart.ChartAreas.Add(new ChartArea(Name = "StartedChart"));

            Series serie = new Series
            {
                ChartType = 0,
                MarkerSize = 10,
                Name = "Starting chart serie"
            };

            for (int i = 0; i < _uploadedData.Length; i++)
            {
                serie.Points.AddXY(_uploadedData[i][0], _uploadedData[i][1]);
            }

            startingDataChart.Series.Add(serie);
        }
    }
}
