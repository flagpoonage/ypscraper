namespace YPScraper
{
    partial class DataScrapePanel
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
            this.statusLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pSearchedTb = new System.Windows.Forms.TextBox();
            this.pRemainTb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lFoundTb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lScrapedTb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.businessList = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tResultsTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // statusLbl
            // 
            this.statusLbl.BackColor = System.Drawing.Color.Transparent;
            this.statusLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.statusLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLbl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.statusLbl.Location = new System.Drawing.Point(12, 10);
            this.statusLbl.Name = "statusLbl";
            this.statusLbl.Size = new System.Drawing.Size(624, 22);
            this.statusLbl.TabIndex = 0;
            this.statusLbl.Text = "Not processed";
            this.statusLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pages Searched";
            // 
            // pSearchedTb
            // 
            this.pSearchedTb.Enabled = false;
            this.pSearchedTb.Location = new System.Drawing.Point(15, 62);
            this.pSearchedTb.Name = "pSearchedTb";
            this.pSearchedTb.Size = new System.Drawing.Size(146, 20);
            this.pSearchedTb.TabIndex = 2;
            // 
            // pRemainTb
            // 
            this.pRemainTb.Enabled = false;
            this.pRemainTb.Location = new System.Drawing.Point(15, 108);
            this.pRemainTb.Name = "pRemainTb";
            this.pRemainTb.Size = new System.Drawing.Size(146, 20);
            this.pRemainTb.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Pages Remaining";
            // 
            // lFoundTb
            // 
            this.lFoundTb.Enabled = false;
            this.lFoundTb.Location = new System.Drawing.Point(15, 200);
            this.lFoundTb.Name = "lFoundTb";
            this.lFoundTb.Size = new System.Drawing.Size(146, 20);
            this.lFoundTb.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Listings Found";
            // 
            // lScrapedTb
            // 
            this.lScrapedTb.Enabled = false;
            this.lScrapedTb.Location = new System.Drawing.Point(15, 247);
            this.lScrapedTb.Name = "lScrapedTb";
            this.lScrapedTb.Size = new System.Drawing.Size(146, 20);
            this.lScrapedTb.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Listings Scraped";
            // 
            // businessList
            // 
            this.businessList.FormattingEnabled = true;
            this.businessList.Location = new System.Drawing.Point(180, 62);
            this.businessList.Name = "businessList";
            this.businessList.Size = new System.Drawing.Size(456, 446);
            this.businessList.TabIndex = 9;
            this.businessList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.businessList_MouseDoubleClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(177, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Business Information Scraped";
            // 
            // tResultsTb
            // 
            this.tResultsTb.Enabled = false;
            this.tResultsTb.Location = new System.Drawing.Point(15, 153);
            this.tResultsTb.Name = "tResultsTb";
            this.tResultsTb.Size = new System.Drawing.Size(146, 20);
            this.tResultsTb.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Total Results";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 286);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 32);
            this.button1.TabIndex = 13;
            this.button1.Text = "Begin Scrape";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(15, 324);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(146, 32);
            this.button2.TabIndex = 14;
            this.button2.Text = "Export Scraped Data";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // DataScrapePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tResultsTb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.businessList);
            this.Controls.Add(this.lScrapedTb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lFoundTb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pRemainTb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pSearchedTb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.statusLbl);
            this.Name = "DataScrapePanel";
            this.Size = new System.Drawing.Size(649, 524);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label statusLbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox pSearchedTb;
        private System.Windows.Forms.TextBox pRemainTb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox lFoundTb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox lScrapedTb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox businessList;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tResultsTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}
