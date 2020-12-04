using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            if(m < uploadedPoints.Count())
            {
                ChooseGroupsCenter();
                FillPointsAndTheirCenters();
                FindNearestCenter();
            }
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

        private void FillPointsAndTheirCenters()
        {
            for(int i = 0; i < _m; i++)
            {
                _pointsAndTheirCenters.Add(new List<MyPoint>());
            }
        }
    }
}
