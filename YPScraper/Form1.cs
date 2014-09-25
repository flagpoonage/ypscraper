using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YPScraper
{
    public partial class Form1 : Form
    {
        public const string ChromeUserAgent = "Mozilla/5.0 (Windows NT 6.2; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/32.0.1667.0 Safari/537.36";

        public Form1()
        {
            InitializeComponent();

            var client = new HtmlClient(ChromeUserAgent);
            var boolOut = false;
            int i = 0;

            this.WhatSelection = new NameValueAndUrl()
            {
                Display = "Clean",
                Value = "clean"
            };

            this.WhereSelection = new NameValueAndUrl()
            {
                Display = "Auckland Region",
                Value = "auckland-region"
            };
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var url = string.Empty;// UriFactory.CreateUrl(this.WhereSelection.Url, this.WhatSelection.Url);

            Task.Factory.StartNew<HtmlAgilityPack.HtmlDocument>(() =>
            {
                this.button3.DDisable();
                this.groupBox2.DDisable();

                this.infoStatusLbl.DSetText("Status: Retrieving page data...");

                var client = new HtmlClient(ChromeUserAgent);

                var boolOut = false;
                var data = client.Get(url, out boolOut);

                this.infoStatusLbl.DSetText("Status: Reading HTML...");

                if (boolOut)
                {
                    HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();

                    doc.LoadHtml(data);

                    htmlResult.DSetText(data);

                    return doc;
                }
                else
                {
                    return null;
                }
            }).ContinueWith((doc) =>
            {
                if (doc.Result == null)
                {
                    this.infoStatusLbl.DSetText("Status: Error downloading information.");
                }
                else
                {
                    this.infoStatusLbl.DSetText("Status: Parsing HTML information...");
                                        
                    var res = YellowPagesParser.Parse(doc.Result, url);

                    this.infoResultsLbl.DSetText(!res.Empty ? res.Results.ToString() + " results found" : "No results found");

                    this.infoPagesLbl.DSetText(!res.Empty ? res.SearchPages.Count.ToString() + " pages of results" : "No pages found");

                    this.infoStatusLbl.DSetText("Status: Complete");

                    this.button3.DEnable();
                    this.groupBox2.DEnable();
                }
            });

        }

        private List<NameValueAndUrl> GetRefinementCategories(HtmlAgilityPack.HtmlDocument doc)
        {
            var list = new List<NameValueAndUrl>();

            var filterContainer = doc.DocumentNode.SelectSingleNode(
                "//html//body//div[@id='contentMainSearchResults']//section[@id='filterModuleSearchResults']//div[@data-name='filter-container']");

            var filters = filterContainer.SelectNodes("//div[@class='filterColumn']//div[@class='filterBlock']");

            HtmlNode categories = null;

            foreach (var f in filters)
            {
                var l = f.SelectSingleNode("//select[@id='refinements_categories']");

                if (l != null)
                {
                    categories = l;
                    break;
                }
            }

            if (categories == null)
            {
                return null;
            }

            var options = categories.SelectNodes("//optgroup[@label='Categories']//option");

            foreach (var o in options)
            {
                var rc = new NameValueAndUrl();

                rc.Display = o.NextSibling.InnerHtml.Replace("&amp;", "&");
                rc.Value = o.Attributes["value"].Value;

                list.Add(rc);
            }

            return list;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var dialog = new YPApiLookup(APILookupType.Where);
            dialog.ShowDialog();

            if (dialog.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                this.whereTb.Text = dialog.Selected.Display;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var dialog = new YPApiLookup(APILookupType.What);
            dialog.ShowDialog();

            if (dialog.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                this.whatTb.Text = dialog.Selected.Display;
            }
        }

        private void whatTb_TextChanged(object sender, EventArgs e)
        {
            this.WhatSelection = new NameValueAndUrl()
            {
                Display = this.whatTb.Text,
                Value = this.whatTb.Text.ToLower().Replace(' ', '-')
            };
        }

        public NameValueAndUrl WhatSelection { get; set; }

        public NameValueAndUrl WhereSelection { get; set; }

        private void whereTb_TextChanged(object sender, EventArgs e)
        {
            this.WhereSelection = new NameValueAndUrl()
            {
                Display = this.whereTb.Text,
                Value = this.whereTb.Text.ToLower().Replace(' ', '-')
            };
        }

        private void button3_EnabledChanged(object sender, EventArgs e)
        {
            if (this.button3.Enabled)
            {
                this.button3.BackColor = Color.Khaki;
            }
            else
            {
                this.button3.BackColor = Color.LightGray;
            }
        }
    }
}
