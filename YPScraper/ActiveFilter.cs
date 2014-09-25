using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace YPScraper
{
    [Serializable]
    public partial class ActiveFilter : UserControl
    {
        public Filter Filter;

        public ActiveFilter()
        {
            InitializeComponent();
        }

        public ActiveFilter(Filter f)
        {
            this.InitializeComponent();

            this.Filter = f;

            this.filterNameLbl.Text = this.Filter.Name;
            this.filterValueLbl.Text = this.Filter.Value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ((FilterPanel)this.Parent).RemoveFilter(this.Filter);
        }
    }
}
