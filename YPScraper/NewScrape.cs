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
    public partial class NewScrape : Form
    {
        public NewScrape()
        {
            InitializeComponent();
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void whatBtn_Click(object sender, EventArgs e)
        {
            var api = new YPApiLookup(APILookupType.What);

            api.ShowDialog();

            if (api.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                this.whatTb.Text = api.Selected.Display;
            }
        }

        private void whereBtn_Click(object sender, EventArgs e)
        {
            var api = new YPApiLookup(APILookupType.Where);

            api.ShowDialog();

            if (api.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                this.whereTb.Text = api.Selected.Display;
            }
        }

        private void whatTb_TextChanged(object sender, EventArgs e)
        {
            this.What = whatTb.Text;

            this.startBtn.Enabled = !string.IsNullOrEmpty(this.whereTb.Text) && !string.IsNullOrEmpty(this.whatTb.Text); 
        }

        private void whereTb_TextChanged(object sender, EventArgs e)
        {
            this.Where = whereTb.Text;

            this.startBtn.Enabled = !string.IsNullOrEmpty(this.whereTb.Text) && !string.IsNullOrEmpty(this.whatTb.Text); 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        public string Where { get; set; }

        public string What { get; set; }
    }
}
