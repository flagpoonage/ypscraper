using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;

namespace YPScraper
{
    public class HtmlClient
    {
        private string UserAgent;

        public HtmlClient(string userAgent)
        {

            this.UserAgent = userAgent;
        }
        public string Get(string url, out bool success)
        {
            success = false;

            var httpRequest = (HttpWebRequest)HttpWebRequest.Create(url);

            httpRequest.UserAgent = this.UserAgent;

            try
            {
                var response = httpRequest.GetResponse();

                using (var sr = new StreamReader(response.GetResponseStream()))
                {
                    var data = sr.ReadToEnd();

                    success = true;

                    return data;
                }
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }
    }
}
