using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace YPScraper
{
    public class NameValueAndUrl
    {
        public string Display { get; set; }

        public string Value { get; set; }

        public string Url
        {
            get
            {
                return this.GetUrl();
            }
        }

        private string GetUrl()
        {
            var str = this.Value.ToLower().Replace(' ', '+').Replace("&amp;", "&");

            return HttpUtility.UrlEncode(str).Replace("%2b","+").Replace("%2B","+");
        }
    }
}
