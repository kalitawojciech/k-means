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
        private double[][] _uploadedData;
        private int _m;
        private int _iters;

        public KMeansChartForm(double[][] uploadedData, int m, int iters)
        {
            _uploadedData = uploadedData;
            _m = m;
            _iters = iters;
            InitializeComponent();
        }
    }
}
