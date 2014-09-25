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
    public partial class FilterPanel : UserControl
    {
        public FilterControl FilterControl {get;set;}
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        private List<ActiveFilter> Filters { get; set; }

        public delegate void AddNewFilter(Filter f);

        public delegate void RemoveOldFilter(Filter f);

        public event AddNewFilter FilterAdded;

        public event RemoveOldFilter FilterRemoved;

        public FilterPanel()
        {
            InitializeComponent();

            this.Filters = new List<ActiveFilter>();
        }

        public List<ActiveFilter> GetFilters()
        {
            return this.Filters;
        }


        public void CreateFilterControl(List<YellowPagesFilter> filters)
        {
            if (filters == null)
            {
                return;
            }

            filters = filters.Where(a => a.Values.Length > 1).ToList();

            var fc = new FilterControl(filters);

            fc.Top = 0;
            fc.Left = 0;

            var name = "ACT_Filter";

            fc.Name = name;

            this.DRemoveControl(this.FilterControl);

            this.FilterControl = fc;

            this.DAddControl(this.FilterControl);
        }

        internal void ActivateFilter(YellowPagesFilter filter, string value)
        {            
            var f = new Filter(filter, value);

            if (this.FilterAdded != null)
            {
                this.FilterAdded(f);
            }
        }

        public void AppendFilter(Filter f)
        {
            var fCtrl = new ActiveFilter(f);            

            this.DAddControl(fCtrl);

            this.Filters.Add(fCtrl);

            this.ArrangeFilters();
        }

        private void ArrangeFilters()
        {
            var startAt = 70;

            var idx = 0;

            foreach (var ctrl in this.Filters)
            {
                ctrl.DSetTop(startAt + (idx * 50));

                idx++;
            }
        }

        internal void RemoveFilter(Filter filter)
        {
            if (this.FilterRemoved != null)
            {
                this.FilterRemoved(filter);
            }
        }

        public void DestroyFilter(Filter f)
        {
            var fCtrl = this.Filters.SingleOrDefault(a => a.Filter == f);

            this.Filters.Remove(fCtrl);

            if (fCtrl != null)
            {
                this.DRemoveControl(fCtrl);

                this.ArrangeFilters();
            }
        }
    }
}
