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
    public partial class FilterControl : UserControl
    {
        private List<YellowPagesFilter> filters;

        public FilterControl(List<YellowPagesFilter> filters)
        {
            this.InitializeComponent();
            this.filters = filters;

            var res = filters.Select(a => a.Name);

            this.comboBox1.Items.AddRange(res.ToArray());

            this.comboBox1.SelectedValueChanged += comboBox1_SelectedValueChanged;
        }



        void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            var results = this.filters.SingleOrDefault(a => a.Name == (string)this.comboBox1.SelectedItem);

            this.comboBox2.Items.Clear();

            this.comboBox2.Items.AddRange(results.Values.Select(a => a.Display).ToArray());
        }

        private void activateBtn_Click(object sender, EventArgs e)
        {
            ((FilterPanel)this.Parent)
                .ActivateFilter(this.filters.SingleOrDefault(a => a.Name == (string)this.comboBox1.SelectedItem), (string)this.comboBox2.SelectedItem);
        }
    }
}
