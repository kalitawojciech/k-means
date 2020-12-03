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
    public partial class MenuForm : Form
    {
        public double[][] uploadedData;

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


                    string fileData = System.IO.File.ReadAllText(filePath); // wczytujemy treść pliku do zmiennej
                    string[] rows = fileData.Trim().Split(new char[] { '\n' }); // treść pliku dzielimy wg znaku końca linii, dzięki czemu otrzymamy każdy wiersz w oddzielnej komórce tablicy
                    double[][] uploadedData = new double[rows.Length][];   // Tworzymy zmienną, która będzie przechowywała wczytane dane. Tablica będzie miała tyle wierszy ile wierszy było z wczytanego poliku

                    for (int i = 0; i < rows.Length; i++)
                    {
                        string row = rows[i].Trim();     // przypisuję i-ty element tablicy do zmiennej wiersz
                        string[] cyfry = row.Split(new char[] { ' ' });   // dzielimy wiersz po znaku spacji, dzięki czemu otrzymamy tablicę cyfry, w której każda oddzielna komórka to cyfra z wiersza
                        cyfry = cyfry.Where(x => x != "").ToArray();
                        uploadedData[i] = new double[cyfry.Length];    // Do tablicy w której będą dane finalne dokładamy wiersz w postaci tablicy integerów tak długą jak długa jest tablica cyfry, czyli tyle ile było cyfr w jednym wierszu
                        for (int j = 0; j < cyfry.Length; j++)
                        {
                            string cyfra = cyfry[j].Trim(); // przypisuję j-tą cyfrę do zmiennej cyfra
                            uploadedData[i][j] = StringToDouble(cyfra);
                        }
                    }

                    this.uploadedData = uploadedData;
                    int lastBackslashIndex = filePath.LastIndexOf('\\') + 1;
                    this.fileNameTextBox.Text = filePath.Substring(lastBackslashIndex,  filePath.Length - lastBackslashIndex);
                    this.kMeansButton.Enabled = true;

                }
            }
        }

        private void kMeansButton_Click(object sender, EventArgs e)
        {
            StartingDrawForm startingDrawFrom = new StartingDrawForm(uploadedData);
            startingDrawFrom.Show();
            startingDrawFrom.DrawStartingChart();

            KMeansChartForm kMeansChartForm = new KMeansChartForm(uploadedData, (int)this.mInput.Value, (int)this.ItersInput.Value);
            WaitSomeTime();
            kMeansChartForm.Show();
        }

        private static double StringToDouble(string number)
        {
            double result;
            number = number.Trim();
            if (!double.TryParse(number.Replace(',', '.'), out result) && !double.TryParse(number.Replace('.', ','), out result))
                throw new Exception("Nie udało się skonwertować liczby do double");

            return result;
        }

        private async void WaitSomeTime()
        {
            await Task.Delay(1000);
        }
    }
}
