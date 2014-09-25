namespace YPScraper
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.whatTb = new System.Windows.Forms.TextBox();
            this.whereTb = new System.Windows.Forms.TextBox();
            this.htmlResult = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.infoStatusLbl = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.infoResultsLbl = new System.Windows.Forms.Label();
            this.infoPagesLbl = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
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
            // whatTb
            // 
            this.whatTb.Location = new System.Drawing.Point(12, 37);
            this.whatTb.Name = "whatTb";
            this.whatTb.Size = new System.Drawing.Size(283, 20);
            this.whatTb.TabIndex = 4;
            this.whatTb.Text = "Clean";
            this.whatTb.TextChanged += new System.EventHandler(this.whatTb_TextChanged);
            // 
            // whereTb
            // 
            this.whereTb.Location = new System.Drawing.Point(12, 80);
            this.whereTb.Name = "whereTb";
            this.whereTb.Size = new System.Drawing.Size(283, 20);
            this.whereTb.TabIndex = 5;
            this.whereTb.Text = "Auckland Region";
            this.whereTb.TextChanged += new System.EventHandler(this.whereTb_TextChanged);
            // 
            // htmlResult
            // 
            this.htmlResult.BackColor = System.Drawing.SystemColors.Control;
            this.htmlResult.Location = new System.Drawing.Point(6, 24);
            this.htmlResult.Multiline = true;
            this.htmlResult.Name = "htmlResult";
            this.htmlResult.ReadOnly = true;
            this.htmlResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.htmlResult.Size = new System.Drawing.Size(660, 503);
            this.htmlResult.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(301, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(301, 78);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(30, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "...";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
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
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Khaki;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(12, 180);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(165, 35);
            this.button3.TabIndex = 10;
            this.button3.Text = "Info Scrape";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.EnabledChanged += new System.EventHandler(this.button3_EnabledChanged);
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.whatTb);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.whereTb);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(339, 150);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Yellow Pages Options";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 114);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(127, 23);
            this.button4.TabIndex = 9;
            this.button4.Text = "Select Filters";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.infoPagesLbl);
            this.groupBox1.Controls.Add(this.infoResultsLbl);
            this.groupBox1.Controls.Add(this.infoStatusLbl);
            this.groupBox1.Location = new System.Drawing.Point(12, 235);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(339, 96);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Info Scrape Results";
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
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.LightGray;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.Enabled = false;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(183, 180);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(168, 35);
            this.button5.TabIndex = 14;
            this.button5.Text = "Data Scrape";
            this.button5.UseVisualStyleBackColor = false;
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
            // infoPagesLbl
            // 
            this.infoPagesLbl.AutoSize = true;
            this.infoPagesLbl.Location = new System.Drawing.Point(9, 70);
            this.infoPagesLbl.Name = "infoPagesLbl";
            this.infoPagesLbl.Size = new System.Drawing.Size(83, 13);
            this.infoPagesLbl.TabIndex = 2;
            this.infoPagesLbl.Text = "No pages found";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(368, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(669, 559);
            this.tabControl1.TabIndex = 16;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.htmlResult);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(661, 533);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "HTML Info Page";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(672, 533);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Data Scrape Processing";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 583);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "YPParse";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox whatTb;
        private System.Windows.Forms.TextBox whereTb;
        private System.Windows.Forms.TextBox htmlResult;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label infoStatusLbl;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label infoPagesLbl;
        private System.Windows.Forms.Label infoResultsLbl;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}

