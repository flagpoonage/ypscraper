namespace YPScraper
{
    partial class NewScrape
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
            this.label2 = new System.Windows.Forms.Label();
            this.whatTb = new System.Windows.Forms.TextBox();
            this.whereBtn = new System.Windows.Forms.Button();
            this.whereTb = new System.Windows.Forms.TextBox();
            this.whatBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.startBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
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
            this.whatTb.TextChanged += new System.EventHandler(this.whatTb_TextChanged);
            // 
            // whereBtn
            // 
            this.whereBtn.Location = new System.Drawing.Point(301, 78);
            this.whereBtn.Name = "whereBtn";
            this.whereBtn.Size = new System.Drawing.Size(30, 23);
            this.whereBtn.TabIndex = 8;
            this.whereBtn.Text = "...";
            this.whereBtn.UseVisualStyleBackColor = true;
            this.whereBtn.Click += new System.EventHandler(this.whereBtn_Click);
            // 
            // whereTb
            // 
            this.whereTb.Location = new System.Drawing.Point(12, 80);
            this.whereTb.Name = "whereTb";
            this.whereTb.Size = new System.Drawing.Size(283, 20);
            this.whereTb.TabIndex = 5;
            this.whereTb.TextChanged += new System.EventHandler(this.whereTb_TextChanged);
            // 
            // whatBtn
            // 
            this.whatBtn.Location = new System.Drawing.Point(301, 35);
            this.whatBtn.Name = "whatBtn";
            this.whatBtn.Size = new System.Drawing.Size(30, 23);
            this.whatBtn.TabIndex = 7;
            this.whatBtn.Text = "...";
            this.whatBtn.UseVisualStyleBackColor = true;
            this.whatBtn.Click += new System.EventHandler(this.whatBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.startBtn);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.whatTb);
            this.groupBox2.Controls.Add(this.whereBtn);
            this.groupBox2.Controls.Add(this.whereTb);
            this.groupBox2.Controls.Add(this.whatBtn);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(341, 169);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Scrape Options";
            // 
            // startBtn
            // 
            this.startBtn.Enabled = false;
            this.startBtn.Location = new System.Drawing.Point(12, 117);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(143, 33);
            this.startBtn.TabIndex = 9;
            this.startBtn.Text = "Start Info Scrape";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.button3_Click);
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
            // NewScrape
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 198);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewScrape";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "NewScrape";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox whatTb;
        private System.Windows.Forms.Button whereBtn;
        private System.Windows.Forms.TextBox whereTb;
        private System.Windows.Forms.Button whatBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Label label1;
    }
}