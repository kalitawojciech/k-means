
namespace k_srednich
{
    partial class KMeansChartForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.kMeansChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.iterationsLeftLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.kMeansChart)).BeginInit();
            this.SuspendLayout();
            // 
            // kMeansChart
            // 
            this.kMeansChart.Location = new System.Drawing.Point(0, 0);
            this.kMeansChart.Margin = new System.Windows.Forms.Padding(0);
            this.kMeansChart.Name = "kMeansChart";
            this.kMeansChart.Size = new System.Drawing.Size(1052, 800);
            this.kMeansChart.TabIndex = 0;
            this.kMeansChart.Text = "chart1";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(1056, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Iterations Left";
            // 
            // iterationsLeftLabel
            // 
            this.iterationsLeftLabel.AutoSize = true;
            this.iterationsLeftLabel.Location = new System.Drawing.Point(1103, 38);
            this.iterationsLeftLabel.Name = "iterationsLeftLabel";
            this.iterationsLeftLabel.Size = new System.Drawing.Size(0, 17);
            this.iterationsLeftLabel.TabIndex = 1;
            // 
            // KMeansChartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 803);
            this.Controls.Add(this.iterationsLeftLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kMeansChart);
            this.Name = "KMeansChartForm";
            this.Text = "KMeansChartForm";
            ((System.ComponentModel.ISupportInitialize)(this.kMeansChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart kMeansChart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label iterationsLeftLabel;
    }
}