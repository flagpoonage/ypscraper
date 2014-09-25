namespace YPScraper
{
    partial class YPApiLookup
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
            this.queryTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.searchBtn = new System.Windows.Forms.Button();
            this.resultLst = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.selectBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // queryTb
            // 
            this.queryTb.Location = new System.Drawing.Point(12, 24);
            this.queryTb.Name = "queryTb";
            this.queryTb.Size = new System.Drawing.Size(273, 20);
            this.queryTb.TabIndex = 0;
            this.queryTb.TextChanged += new System.EventHandler(this.queryTb1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Query";
            // 
            // searchBtn
            // 
            this.searchBtn.Enabled = false;
            this.searchBtn.Location = new System.Drawing.Point(291, 21);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(75, 23);
            this.searchBtn.TabIndex = 2;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // resultLst
            // 
            this.resultLst.FormattingEnabled = true;
            this.resultLst.Location = new System.Drawing.Point(12, 71);
            this.resultLst.Name = "resultLst";
            this.resultLst.Size = new System.Drawing.Size(354, 108);
            this.resultLst.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Results";
            // 
            // selectBtn
            // 
            this.selectBtn.Location = new System.Drawing.Point(237, 185);
            this.selectBtn.Name = "selectBtn";
            this.selectBtn.Size = new System.Drawing.Size(129, 23);
            this.selectBtn.TabIndex = 5;
            this.selectBtn.Text = "Select Result";
            this.selectBtn.UseVisualStyleBackColor = true;
            this.selectBtn.Click += new System.EventHandler(this.selectBtn_Click);
            // 
            // YPApiLookup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 224);
            this.Controls.Add(this.selectBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.resultLst);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.queryTb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "YPApiLookup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Search Yellow Pages";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox queryTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.ListBox resultLst;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button selectBtn;
    }
}