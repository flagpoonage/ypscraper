using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YPScraper
{
    public class YellowPagesDataScraper
    {
        public YellowPagesInfoResults Info { get; set; }

        public delegate void MessageHandler(string message);

        public delegate void PageScrapedHandler();

        public delegate void PageAddedHandler(int amount);

        public delegate void ListingScrapedHandler(YellowPagesBusinessListing listing);

        public delegate void ListingsFoundHandler(int amount);

        public event MessageHandler Message;

        public event PageScrapedHandler PageScraped;

        public event PageAddedHandler PageAdded;

        public event ListingScrapedHandler ListingScraped;

        public event ListingsFoundHandler ListingsFound;

        public string FilterString { get; set; }

        public YellowPagesDataScraper(YellowPagesInfoResults info)
        {
            this.Info = info;

            this.FilterString = string.Empty;
        }

        protected void OnMessage(string message)
        {
            if (this.Message != null)
            {
                this.Message(message);
            }
        }

        protected void OnPageScraped()
        {
            if (this.PageScraped != null)
            {
                this.PageScraped();
            }
        }

        protected void OnPageAdded(int amount)
        {
            if (this.PageAdded != null)
            {
                this.PageAdded(amount);
            }
        }

        protected void OnListingScraped(YellowPagesBusinessListing listing)
        {
            if (this.ListingScraped != null)
            {
                this.ListingScraped(listing);
            }
        }

        protected void OnListingsFound(int amount)
        {
            if (this.ListingsFound != null)
            {
                this.ListingsFound(amount);
            }
        }

        public YellowPagesDataResults Begin()
        {
            var result = new YellowPagesDataResults()
            {
                Listings = new List<YellowPagesBusinessListing>()
            };

            var client = new HtmlClient(ScrapeControl.ChromeUserAgent);

            for(int i = 0; i < this.Info.SearchPages.Count; i++)
            {
                this.Message("Requesting URL..");

                var success = false;

                var requestUrl = string.Format("{0}{1}", 
                    this.Info.SearchPages[i].Url, 
                    string.IsNullOrEmpty(this.FilterString) 
                        ? string.Empty 
                        : "?" + this.FilterString);

                var data = client.Get(requestUrl, out success);

                var uri = new Uri(this.Info.SearchPages[i].Url);
                
                if (success)
                {
                    this.PageScraped();

                    var hdoc = new HtmlAgilityPack.HtmlDocument();

                    hdoc.LoadHtml(data);

                    this.Message("Retrieving page listings...");

                    result.Listings.AddRange(this.FindPageListings(hdoc.DocumentNode, uri));

                    // Limit is imposed by yellow pages to prevent scraping.
                    if (result.Listings.Count < 180)
                    {
                        var pages = this.FindAdditionalPages(hdoc.DocumentNode, uri);

                        pages = this.AddNewPages(pages);

                        if (pages.Any())
                        {
                            this.PageAdded(pages.Count);

                            this.Info.SearchPages.AddRange(pages);
                        }
                    }
                }
            }

            for(int i = 0; i < result.Listings.Count; i++)
            {
                result.Listings[i] = this.ScrapeBusiness(result.Listings[i]);
            }

            this.Message("Data scrape completed.");

            return result;
        }

        private YellowPagesBusinessListing ScrapeBusiness(YellowPagesBusinessListing bs)
        {
            this.Message(string.Format("Scraping {0}..", bs.BusinessName));

            var client = new HtmlClient(ScrapeControl.ChromeUserAgent);

            var success = false;

            var data = client.Get(bs.URL, out success);

            var hdoc = new HtmlAgilityPack.HtmlDocument();

            hdoc.LoadHtml(data);

            bs = YellowPagesBusinessParser.Parse(hdoc.DocumentNode, bs);

            this.ListingScraped(bs);

            return bs;
        }

        private List<YellowPagesSearchPage> AddNewPages(List<YellowPagesSearchPage> pages)
        {
            var list = new List<YellowPagesSearchPage>();

            foreach (var page in pages)
            {
                var isFound = false;

                for (int i = 0; i < this.Info.SearchPages.Count; i++)
                {
                    if (page.Url == this.Info.SearchPages[i].Url)
                    {
                        isFound = true;
                        break;
                    }
                }

                if (!isFound)
                {
                    list.Add(page);
                }
            }

            return list;
        }

        private List<YellowPagesSearchPage> FindAdditionalPages(HtmlNode document, Uri uri)
        {
            var list = new List<YellowPagesSearchPage>();

            var pagination = document.SelectSingleNode("//html//body//div[@id='contentMainSearchResults']//section[@class='pagination']");

            if (pagination == null)
            {
                return list;
            }

            var pageList = pagination.SelectNodes("//ul[@class='right']//li//a");

            if (pageList == null)
            {
                return list;
            }

            foreach (var item in pageList)
            {
                var isCurrent = item.Attributes["class"] != null && item.Attributes["class"].Value == "current";
                
                var begin = string.Format("http://{0}", uri.Host);

                if (!isCurrent)
                {
                    if (!item.InnerHtml.Contains("Next") && !item.InnerHtml.Contains("Previous"))
                    {
                        var href = string.Format("{0}{1}", begin, item.Attributes["href"].Value);

                        var hrefUri = new Uri(href);

                        var page = new YellowPagesSearchPage()
                        {
                            Url = string.Format("{0}{1}", begin, hrefUri.AbsolutePath)
                        };

                        list.Add(page);
                    }
                }
            }

            return list;
        }

        private List<YellowPagesBusinessListing> FindPageListings(HtmlNode document, Uri url)
        {
            var bList = new List<YellowPagesBusinessListing>();

            var ol = document.SelectSingleNode("//html//body//div[@id='contentMainSearchResults']//section//ol[@id='searchResultsList']");

            if (ol == null)
            {
                return null;
            }

            var listings = ol.SelectNodes("//div[contains(@class,'resultsListItem')]//div[@class='itemTitle']");

            if (listings == null || !listings.Any())
            {
                return bList;
            }

            foreach (var listing in listings)
            {
                var bs = new YellowPagesBusinessListing();

                bs.BusinessName = listing.Attributes["title"].Value.Replace("&amp;","&");

                var moreinfo = listing.SelectSingleNode(string.Format("{0}//div[@class='itemTools']//div[@class='itemActions']//a", listing.XPath));

                bs.URL = string.Format("http://{0}{1}", url.Host, moreinfo.Attributes["href"].Value);

                bList.Add(bs);

                this.ListingsFound(1);
            }

            return bList;
        }

        private void ScrapePageListings(HtmlNode htmlNode)
        {
            throw new NotImplementedException();
        }
    }
}
