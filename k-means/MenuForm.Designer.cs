namespace k_srednich
{
    partial class MenuForm
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
            this.chooseFileButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.fileNameTextBox = new System.Windows.Forms.TextBox();
            this.kMeansButton = new System.Windows.Forms.Button();
            this.ItersInput = new System.Windows.Forms.NumericUpDown();
            this.mInput = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ItersInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mInput)).BeginInit();
            this.SuspendLayout();
            // 
            // chooseFileButton
            // 
            this.chooseFileButton.Location = new System.Drawing.Point(9, 114);
            this.chooseFileButton.Name = "chooseFileButton";
            this.chooseFileButton.Size = new System.Drawing.Size(274, 77);
            this.chooseFileButton.TabIndex = 0;
            this.chooseFileButton.Text = "Choose File";
            this.chooseFileButton.UseVisualStyleBackColor = true;
            this.chooseFileButton.Click += new System.EventHandler(this.chooseFileButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "File Name";
            // 
            // fileNameTextBox
            // 
            this.fileNameTextBox.Location = new System.Drawing.Point(84, 76);
            this.fileNameTextBox.Name = "fileNameTextBox";
            this.fileNameTextBox.ReadOnly = true;
            this.fileNameTextBox.Size = new System.Drawing.Size(200, 22);
            this.fileNameTextBox.TabIndex = 2;
            // 
            // kMeansButton
            // 
            this.kMeansButton.Enabled = false;
            this.kMeansButton.Location = new System.Drawing.Point(9, 208);
            this.kMeansButton.Name = "kMeansButton";
            this.kMeansButton.Size = new System.Drawing.Size(273, 77);
            this.kMeansButton.TabIndex = 3;
            this.kMeansButton.Text = "k-means";
            this.kMeansButton.UseVisualStyleBackColor = true;
            this.kMeansButton.Click += new System.EventHandler(this.kMeansButton_Click);
            // 
            // ItersInput
            // 
            this.ItersInput.Location = new System.Drawing.Point(84, 37);
            this.ItersInput.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.ItersInput.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.ItersInput.Name = "ItersInput";
            this.ItersInput.Size = new System.Drawing.Size(200, 22);
            this.ItersInput.TabIndex = 4;
            this.ItersInput.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // mInput
            // 
            this.mInput.Location = new System.Drawing.Point(84, 5);
            this.mInput.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.mInput.Name = "mInput";
            this.mInput.Size = new System.Drawing.Size(200, 22);
            this.mInput.TabIndex = 5;
            this.mInput.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Iters";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "M";
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 292);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mInput);
            this.Controls.Add(this.ItersInput);
            this.Controls.Add(this.kMeansButton);
            this.Controls.Add(this.fileNameTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chooseFileButton);
            this.Name = "MenuForm";
            this.Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)(this.ItersInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button chooseFileButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox fileNameTextBox;
        private System.Windows.Forms.Button kMeansButton;
        private System.Windows.Forms.NumericUpDown ItersInput;
        private System.Windows.Forms.NumericUpDown mInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

