using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace YPScraper
{
    public partial class ScrapeControl : UserControl
    {
        public const string ChromeUserAgent = "Mozilla/5.0 (Windows NT 6.2; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/32.0.1667.0 Safari/537.36";

        public NameValueAndUrl WhereSelection { get; set; }

        public NameValueAndUrl WhatSelection { get; set; }

        public string FilterString { get; set; }

        private Filter PendingFilter { get; set; }

        private bool PendingFilterRemoval { get; set; }

        public ScrapeControl(string what, string where)
        {
            InitializeComponent();

            this.filterPanel1.FilterAdded += filterPanel1_FilterAdded;
            this.filterPanel1.FilterRemoved += filterPanel1_FilterRemoved;

            this.WhereSelection = new NameValueAndUrl()
            {
                Display = where,
                Value = where.ToLower().Replace(' ', '-')
            };

            this.WhatSelection = new NameValueAndUrl()
            {
                Display = what,
                Value = what.ToLower().Replace(' ', '-')
            };

            this.whatLbl.Text = this.WhatSelection.Display;
            this.whereLbl.Text = this.WhereSelection.Display;

            this.BeginInfoScrape();
        }

        void filterPanel1_FilterRemoved(Filter f)
        {
            var filterString = string.Empty;

            var fl = this.filterPanel1.GetFilters();

            if (fl != null && fl.Any())
            {
                var filters = fl.Where(a => a.Filter != f);

                if (filters.Any())
                {
                    filterString = filters.Select(a => a.Filter.URL).Aggregate((a, b) => string.Format("{0}&{1}", a, b));
                }
            }

            this.PendingFilter = f;
            this.PendingFilterRemoval = true;

            this.FilterString = filterString;

            this.BeginInfoScrape();
        }

        void filterPanel1_FilterAdded(Filter f)
        {
            var filterString = f.URL;

            var fl = this.filterPanel1.GetFilters();

            if (fl != null && fl.Any())
            {
                filterString = fl.Select(a => a.Filter.URL).Aggregate((a, b) => string.Format("{0}&{1}", a, b));

                filterString = string.Format("{0}&{1}", filterString, f.URL);
            }

            this.PendingFilter = f;
            this.PendingFilterRemoval = false;

            this.FilterString = filterString;

            this.BeginInfoScrape();
        }

        public void BeginInfoScrape()
        {
            var url = UriFactory.CreateUrl(this.WhereSelection.Url, this.WhatSelection.Url, this.FilterString);

            Task.Factory.StartNew<HtmlAgilityPack.HtmlDocument>(() =>
            {
                this.DDisable();

                this.infoStatusLbl.DSetText("Status: Retrieving page data...");

                var client = new HtmlClient(ChromeUserAgent);

                var boolOut = false;
                var data = client.Get(url, out boolOut);

                this.infoStatusLbl.DSetText("Status: Reading HTML...");

                if (boolOut)
                {
                    HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();

                    doc.LoadHtml(data);

                    this.htmlResults.DSetText(data);

                    return doc;
                }
                else
                {
                    return null;
                }
            }).ContinueWith((doc) =>
            {
                this.dataScrapePanel1.FilterString = this.FilterString;

                if (doc.Result == null)
                {
                    this.infoStatusLbl.DSetText("Status: Error downloading information.");

                    this.dataScrapePanel1.SetInvalidInfoScrape();

                    this.RemovePendingFilter();
                }
                else
                {
                    this.infoStatusLbl.DSetText("Status: Parsing HTML information...");

                    var res = YellowPagesParser.Parse(doc.Result, url);

                    this.dataScrapePanel1.LoadInfoScrape(res);

                    this.infoResultsLbl.DSetText(!res.Empty ? res.Results.ToString() + " results found" : "No results found");

                    if (res.SearchPages != null)
                    {
                        this.infoPagesLbl.DSetText(!res.Empty ? res.SearchPages.Count.ToString() + " pages of results" : "No pages found");
                    }
                    else
                    {
                        this.infoPagesLbl.DSetText("No result pages found.");
                    }

                    this.RemovePendingFilter();

                    this.filterPanel1.CreateFilterControl(res.AdditionalFilters);

                    this.infoStatusLbl.DSetText("Status: Complete");
                }

                this.DEnable();
            });
        }

        private void RemovePendingFilter()
        {
            if (PendingFilter != null)
            {
                if (this.PendingFilterRemoval)
                {
                    this.filterPanel1.DestroyFilter(this.PendingFilter);
                }
                else
                {
                    this.filterPanel1.AppendFilter(this.PendingFilter);
                }

                this.PendingFilter = null;
            }
        }
    }
}
