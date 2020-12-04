using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace k_srednich
{
    public partial class KMeansChartForm : Form
    {
        private List<MyPoint> _uploadedPoints;
        private List<MyPoint> _groupsCenters;
        private List<List<MyPoint>> _pointsAndTheirCenters = new List<List<MyPoint>>();
        private int _m;
        private int _iters;

        public KMeansChartForm(List<MyPoint> uploadedPoints, int m, int iters)
        {
            _uploadedPoints = uploadedPoints;
            _m = m;
            _iters = iters;
            InitializeComponent();
        }

        public async Task KMeansFunction()
        {
            this.Enabled = false;
            this.iterationsLeftLabel.Text = _iters.ToString();
            if (_m < _uploadedPoints.Count())
            {
                ChooseGroupsCenter();
                FillPointsAndTheirCenters();
                FindNearestCenter();
                FindNewCenters();
                DrawKMeansChart();
                await Task.Delay(2000);
                for (int i = 0; i < _iters; i++)
                {
                    this.iterationsLeftLabel.Text = (_iters - i - 1).ToString();
                    ResetPointsAndTheirCenters();
                    FindNearestCenter();
                    FindNewCenters();
                    DrawKMeansChart();
                    await Task.Delay(1000);
                }
            }

            this.Enabled = true;
        }

        public void ChooseGroupsCenter()
        {
            Random rnd = new Random();
            _groupsCenters = _uploadedPoints.OrderBy(x => rnd.Next()).Take(_m).ToList();
        }

        public void FindNearestCenter()
        {
            foreach(MyPoint point in _uploadedPoints)
            {
                double distance = -1;
                int nearestCenterIndex = -1;
                int index = 0;
                foreach(MyPoint center in _groupsCenters)
                {
                    double distanceFromCenter = Math.Sqrt((point.X - center.X) * (point.X - center.X) + (point.Y - center.Y) * (point.Y - center.Y));

                    if(nearestCenterIndex == -1)
                    {
                        distance = distanceFromCenter;
                        nearestCenterIndex = index;
                    }
                    else if(distance > distanceFromCenter)
                    {
                        distance = distanceFromCenter;
                        nearestCenterIndex = index;
                    }

                    index++;
                }

                _pointsAndTheirCenters[nearestCenterIndex].Add(point);

            }
        }

        public void FindNewCenters()
        {
            for(int i = 0; i < _m; i++)
            {
                double sumOfX = 0d;
                double sumOfY = 0d;
                int pointsInGroupCount = _pointsAndTheirCenters[i].Count();

                foreach(MyPoint point in _pointsAndTheirCenters[i])
                {
                    sumOfX += point.X;
                    sumOfY += point.Y;
                }

                _groupsCenters[i] = new MyPoint(sumOfX / (double)pointsInGroupCount, sumOfY / (double)pointsInGroupCount);

            }
        }

        public void DrawKMeansChart()
        {
            kMeansChart.Series.Clear();
            kMeansChart.ChartAreas.Clear();
            kMeansChart.Legends.Clear();

            kMeansChart.ChartAreas.Add(new ChartArea(Name = "kMeans"));

            Legend legend = new Legend();
            legend.Name = "Legend";
            kMeansChart.Legends.Add(legend);

            for (int i = 0; i < _m; i++)
            {
                Series serieOfCetnerPoint = new Series
                {
                    Name = $"Center of group number: {i}",
                    ChartType = 0,
                    MarkerSize = 20
                };

                serieOfCetnerPoint.Points.AddXY(_groupsCenters[i].X, _groupsCenters[i].Y);
                kMeansChart.Series.Add(serieOfCetnerPoint);

                Series serieOfActualGroup = new Series
                {
                    Name = $"Group number: {i}"
                };

                foreach(MyPoint point in _pointsAndTheirCenters[i])
                {
                    serieOfActualGroup.Points.AddXY(point.X, point.Y);
                    serieOfActualGroup.ChartType = 0;
                    serieOfActualGroup.MarkerSize = 10;
                }

                kMeansChart.Series.Add(serieOfActualGroup);
            }
        }

        private void FillPointsAndTheirCenters()
        {
            for(int i = 0; i < _m; i++)
            {
                _pointsAndTheirCenters.Add(new List<MyPoint>());
            }
        }

        private void ResetPointsAndTheirCenters()
        {
            for (int i = 0; i < _m; i++)
            {
                _pointsAndTheirCenters[i].Clear();
            }
        }
    }
}
