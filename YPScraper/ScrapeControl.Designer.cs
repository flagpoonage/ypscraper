namespace YPScraper
{
    partial class ScrapeControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.infoPagesLbl = new System.Windows.Forms.Label();
            this.infoResultsLbl = new System.Windows.Forms.Label();
            this.infoStatusLbl = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.whereLbl = new System.Windows.Forms.Label();
            this.whatLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.htmlResults = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.filterPanel1 = new YPScraper.FilterPanel();
            this.dataScrapePanel1 = new YPScraper.DataScrapePanel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.infoPagesLbl);
            this.groupBox1.Controls.Add(this.infoResultsLbl);
            this.groupBox1.Controls.Add(this.infoStatusLbl);
            this.groupBox1.Location = new System.Drawing.Point(12, 129);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(339, 96);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Info Scrape Results";
            // 
            // infoPagesLbl
            // 
            this.infoPagesLbl.AutoSize = true;
            this.infoPagesLbl.Location = new System.Drawing.Point(9, 70);
            this.infoPagesLbl.Name = "infoPagesLbl";
            this.infoPagesLbl.Size = new System.Drawing.Size(83, 13);
            this.infoPagesLbl.TabIndex = 2;
            this.infoPagesLbl.Text = "No pages found";
            // 
            // infoResultsLbl
            // 
            this.infoResultsLbl.AutoSize = true;
            this.infoResultsLbl.Location = new System.Drawing.Point(9, 46);
            this.infoResultsLbl.Name = "infoResultsLbl";
            this.infoResultsLbl.Size = new System.Drawing.Size(84, 13);
            this.infoResultsLbl.TabIndex = 1;
            this.infoResultsLbl.Text = "No results found";
            // 
            // infoStatusLbl
            // 
            this.infoStatusLbl.AutoSize = true;
            this.infoStatusLbl.Location = new System.Drawing.Point(8, 22);
            this.infoStatusLbl.Name = "infoStatusLbl";
            this.infoStatusLbl.Size = new System.Drawing.Size(60, 13);
            this.infoStatusLbl.TabIndex = 0;
            this.infoStatusLbl.Text = "Status: Idle";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.whereLbl);
            this.groupBox2.Controls.Add(this.whatLbl);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(339, 108);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Yellow Pages Options";
            // 
            // whereLbl
            // 
            this.whereLbl.AutoSize = true;
            this.whereLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.whereLbl.Location = new System.Drawing.Point(9, 80);
            this.whereLbl.Name = "whereLbl";
            this.whereLbl.Size = new System.Drawing.Size(104, 13);
            this.whereLbl.TabIndex = 11;
            this.whereLbl.Text = "Auckland Region";
            // 
            // whatLbl
            // 
            this.whatLbl.AutoSize = true;
            this.whatLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.whatLbl.Location = new System.Drawing.Point(9, 37);
            this.whatLbl.Name = "whatLbl";
            this.whatLbl.Size = new System.Drawing.Size(39, 13);
            this.whatLbl.TabIndex = 10;
            this.whatLbl.Text = "Clean";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "What";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Where";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(368, 15);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(669, 559);
            this.tabControl1.TabIndex = 21;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.filterPanel1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(661, 533);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Filtering";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.htmlResults);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(661, 533);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Current Info Scrape";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // htmlResults
            // 
            this.htmlResults.BackColor = System.Drawing.SystemColors.Control;
            this.htmlResults.Location = new System.Drawing.Point(6, 24);
            this.htmlResults.Multiline = true;
            this.htmlResults.Name = "htmlResults";
            this.htmlResults.ReadOnly = true;
            this.htmlResults.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.htmlResults.Size = new System.Drawing.Size(649, 503);
            this.htmlResults.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "HTML Results";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataScrapePanel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(661, 533);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Data Scrape Processing";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // filterPanel1
            // 
            this.filterPanel1.FilterControl = null;
            this.filterPanel1.Location = new System.Drawing.Point(6, 3);
            this.filterPanel1.Name = "filterPanel1";
            this.filterPanel1.Size = new System.Drawing.Size(649, 524);
            this.filterPanel1.TabIndex = 0;
            // 
            // dataScrapePanel1
            // 
            this.dataScrapePanel1.Location = new System.Drawing.Point(6, 6);
            this.dataScrapePanel1.Name = "dataScrapePanel1";
            this.dataScrapePanel1.Size = new System.Drawing.Size(649, 524);
            this.dataScrapePanel1.TabIndex = 0;
            // 
            // ScrapeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.tabControl1);
            this.Name = "ScrapeControl";
            this.Size = new System.Drawing.Size(1050, 598);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label infoPagesLbl;
        private System.Windows.Forms.Label infoResultsLbl;
        private System.Windows.Forms.Label infoStatusLbl;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox htmlResults;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label whereLbl;
        private System.Windows.Forms.Label whatLbl;
        private System.Windows.Forms.TabPage tabPage3;
        private FilterPanel filterPanel1;
        private DataScrapePanel dataScrapePanel1;
    }
}
