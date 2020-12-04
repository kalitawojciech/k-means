using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace k_srednich
{
    public partial class MenuForm : Form
    {
        public List<MyPoint> uploadedData = new List<MyPoint>();

        public MenuForm()
        {
            InitializeComponent();
        }

        private void chooseFileButton_Click(object sender, EventArgs e)
        {
            string filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = @"C:\Users\wojte\Desktop";
                openFileDialog.FilterIndex = 2;
                openFileDialog.Filter = "Text files (*.txt)|*.txt";
                openFileDialog.RestoreDirectory = false;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialog.FileName;


                    string fileData = System.IO.File.ReadAllText(filePath);
                    string[] rows = fileData.Trim().Split(new char[] { '\n' });


                    for (int i = 0; i < rows.Length; i++)
                    {
                        string row = rows[i].Trim();
                        string[] cyfry = row.Split(new char[] { ' ' });
                        cyfry = cyfry.Where(x => x != "").ToArray();

                        uploadedData.Add(new MyPoint(StringToDouble(cyfry[0].Trim()), StringToDouble(cyfry[1].Trim())));

                    }

                    int lastBackslashIndex = filePath.LastIndexOf('\\') + 1;
                    this.fileNameTextBox.Text = filePath.Substring(lastBackslashIndex,  filePath.Length - lastBackslashIndex);
                    this.kMeansButton.Enabled = true;

                }
            }
        }

        private async void kMeansButton_Click(object sender, EventArgs e)
        {
            StartingDrawForm startingDrawFrom = new StartingDrawForm(uploadedData);
            startingDrawFrom.Show();
            startingDrawFrom.DrawStartingChart();

            KMeansChartForm kMeansChartForm = new KMeansChartForm(uploadedData, (int)this.mInput.Value, (int)this.ItersInput.Value);
            kMeansChartForm.Show();
            await kMeansChartForm.KMeansFunction();
        }

        private static double StringToDouble(string number)
        {
            double result;
            number = number.Trim();
            if (!double.TryParse(number.Replace(',', '.'), out result) && !double.TryParse(number.Replace('.', ','), out result))
                throw new Exception("Nie udało się skonwertować liczby do double");

            return result;
        }
    }
}
