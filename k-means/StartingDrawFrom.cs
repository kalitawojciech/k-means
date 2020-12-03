using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace k_srednich
{
    public partial class StartingDrawFrom : Form
    {
        private double[][] _uploadedData;

        public StartingDrawFrom(double[][] uploadedData)
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
