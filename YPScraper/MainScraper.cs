using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace YPScraper
{
    public partial class MainScraper : Form
    {
        public MainScraper()
        {
            InitializeComponent();
        }

        private void newScrapeBtn_Click(object sender, EventArgs e)
        {
            this.NewScrape();
        }

        private void newScrapeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.NewScrape();
        }

        private void rescrapeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ((ScrapeControl)this.tabControl1.SelectedTab.Controls[0]).BeginInfoScrape();
        }

        private void closeScrapeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.tabControl1.DRemoveControl(this.tabControl1.SelectedTab);

            if (this.tabControl1.TabPages.Count == 0)
            {
                this.tabControl1.Visible = false;
                this.scrapeToolStripMenuItem.Enabled = false;
                this.closeScrapeToolStripMenuItem.Enabled = false;
            }
        }

        private void CreateNewScrape(string where, string what)
        {
            var scrape = new ScrapeControl(what, where);

            var tab = new TabPage();

            tab.Controls.Add(scrape);

            tab.Text = string.Format("{0}, {1}", what, where);

            tabControl1.TabPages.Add(tab);

            tabControl1.SelectedTab = tab;

            if (!tabControl1.Visible)
            {
                tabControl1.Show();
                this.scrapeToolStripMenuItem.Enabled = true;
                this.closeScrapeToolStripMenuItem.Enabled = true;
            }
        }

        private void NewScrape()
        {
            var dg = new NewScrape();

            dg.ShowDialog();

            if (dg.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                this.CreateNewScrape(dg.Where, dg.What);
            }
        }
    }
}
