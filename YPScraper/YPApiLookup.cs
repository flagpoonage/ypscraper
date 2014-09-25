using Newtonsoft.Json;
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
    public partial class YPApiLookup : Form
    {
        public const string WhatURI = "http://yellow.co.nz/services/autocomplete-what/new-zealand/{0}";

        public const string WhereURI = "http://yellow.co.nz/services/autocomplete-where/{0}";

        public APILookupType Type { get; private set; }

        public NameValueAndUrl Selected { get; set; }

        private HtmlClient Client { get; set; }

        public YPApiLookup(APILookupType type)
        {
            this.Type = type;

            InitializeComponent();

            Client = new HtmlClient(Form1.ChromeUserAgent);

            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;

        }

        private void queryTb1_TextChanged(object sender, EventArgs e)
        {
            this.searchBtn.Enabled = !string.IsNullOrEmpty(this.queryTb.Text);
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            this.Enabled = false;

            var success = false;

            string data = string.Empty;

            if (this.Type == APILookupType.What)
            {
                data = this.Client.Get(
                    string.Format(YPApiLookup.WhatURI, this.queryTb.Text), out success);
            }
            else
            {
                data = this.Client.Get(
                    string.Format(YPApiLookup.WhereURI, this.queryTb.Text), out success);
            }

            var obj = (ApiResults)JsonConvert.DeserializeObject(data, typeof(ApiResults));

            resultLst.DataSource = obj.Result;

            this.Enabled = true;
        }

        private void selectBtn_Click(object sender, EventArgs e)
        {
            var str =  (string)this.resultLst.SelectedItem;

            this.Selected = new NameValueAndUrl()
            {
                Display = str,
                Value = str.ToLower().Replace(' ', '-')
            };

            this.DialogResult = System.Windows.Forms.DialogResult.OK;

            this.Close();
        }
    }

    public enum APILookupType
    {
        Where,
        What
    }
}
