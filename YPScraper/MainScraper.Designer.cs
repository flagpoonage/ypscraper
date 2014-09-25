namespace YPScraper
{
    partial class MainScraper
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScraper));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newScrapeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeScrapeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scrapeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rescrapeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.beginDataScrapingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newScrapeBtn = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Location = new System.Drawing.Point(12, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1070, 626);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.scrapeToolStripMenuItem,
            this.dataToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1089, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newScrapeToolStripMenuItem,
            this.closeScrapeToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newScrapeToolStripMenuItem
            // 
            this.newScrapeToolStripMenuItem.Name = "newScrapeToolStripMenuItem";
            this.newScrapeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.newScrapeToolStripMenuItem.Text = "New Scrape...";
            this.newScrapeToolStripMenuItem.Click += new System.EventHandler(this.newScrapeToolStripMenuItem_Click);
            // 
            // closeScrapeToolStripMenuItem
            // 
            this.closeScrapeToolStripMenuItem.Enabled = false;
            this.closeScrapeToolStripMenuItem.Name = "closeScrapeToolStripMenuItem";
            this.closeScrapeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.closeScrapeToolStripMenuItem.Text = "Close Scrape";
            this.closeScrapeToolStripMenuItem.Click += new System.EventHandler(this.closeScrapeToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // scrapeToolStripMenuItem
            // 
            this.scrapeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rescrapeToolStripMenuItem,
            this.beginDataScrapingToolStripMenuItem});
            this.scrapeToolStripMenuItem.Enabled = false;
            this.scrapeToolStripMenuItem.Name = "scrapeToolStripMenuItem";
            this.scrapeToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.scrapeToolStripMenuItem.Text = "Scrape";
            // 
            // rescrapeToolStripMenuItem
            // 
            this.rescrapeToolStripMenuItem.Name = "rescrapeToolStripMenuItem";
            this.rescrapeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.rescrapeToolStripMenuItem.Text = "Rescrape Info";
            this.rescrapeToolStripMenuItem.Click += new System.EventHandler(this.rescrapeToolStripMenuItem_Click);
            // 
            // beginDataScrapingToolStripMenuItem
            // 
            this.beginDataScrapingToolStripMenuItem.Name = "beginDataScrapingToolStripMenuItem";
            this.beginDataScrapingToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.beginDataScrapingToolStripMenuItem.Text = "Begin Data Scraping";
            // 
            // dataToolStripMenuItem
            // 
            this.dataToolStripMenuItem.Enabled = false;
            this.dataToolStripMenuItem.Name = "dataToolStripMenuItem";
            this.dataToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.dataToolStripMenuItem.Text = "Data";
            // 
            // newScrapeBtn
            // 
            this.newScrapeBtn.Location = new System.Drawing.Point(435, 300);
            this.newScrapeBtn.Name = "newScrapeBtn";
            this.newScrapeBtn.Size = new System.Drawing.Size(200, 45);
            this.newScrapeBtn.TabIndex = 2;
            this.newScrapeBtn.Text = "Create a new page scrape";
            this.newScrapeBtn.UseVisualStyleBackColor = true;
            this.newScrapeBtn.Click += new System.EventHandler(this.newScrapeBtn_Click);
            // 
            // MainScraper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 667);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.newScrapeBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainScraper";
            this.Text = "The Yellow Pages";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newScrapeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeScrapeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scrapeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rescrapeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem beginDataScrapingToolStripMenuItem;
        private System.Windows.Forms.Button newScrapeBtn;
    }
}