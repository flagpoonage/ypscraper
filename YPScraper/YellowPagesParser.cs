using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace YPScraper
{
    public class YellowPagesParser
    {
        public static YellowPagesInfoResults Parse(HtmlDocument doc, string url)
        {
            var results = new YellowPagesInfoResults();

            results.Empty = YellowPagesParser.GetNoneFoundAlert(doc.DocumentNode);

            results.AdditionalFilters = YellowPagesParser.GetAdditionalFilters(doc.DocumentNode);

            if (!results.Empty)
            {
                results.Results = YellowPagesParser.GetTotalResults(doc.DocumentNode);

                var normalizedUrl = YellowPagesParser.GetNormalizedCurrent(doc.DocumentNode);

                results.SearchPages = YellowPagesParser.GetSearchPages(doc.DocumentNode, normalizedUrl);
            }

            return results;
        }

        private static string GetNormalizedCurrent(HtmlNode document)
        {
            var link = document.SelectSingleNode("//html//head//link[@rel='canonical']");

            return link.Attributes["href"].Value;
        }

        private static bool GetNoneFoundAlert(HtmlNode document)
        {
            var sections = document.SelectNodes("//html//body//div[@id='contentMainSearchResults']//section");

            HtmlNode sqd = null;

            foreach (var s in sections)
            {
                var n = s.SelectSingleNode("//div[@id='searchQueryDetails']");

                if (n != null)
                {
                    sqd = n;
                }
            }

            var alertSections = sqd.SelectNodes("//section[contains(@class,'alertBox-info')]");

            if (alertSections == null)
            {
                return false;
            }

            foreach (var se in alertSections)
            {
                if (se.InnerText.Contains("Unfortunately we did not find any results for"))
                {
                    return true;
                }
            }

            return false;
        }

        private static int GetTotalResults(HtmlNode document)
        {
            var sections = document.SelectNodes("//html//body//div[@id='contentMainSearchResults']//section");

            HtmlNode sqd = null;

            foreach (var s in sections)
            {
                var n = s.SelectSingleNode("//div[@id='searchQueryDetails']");

                if (n != null)
                {
                    sqd = n;
                }
            }

            var numbers = sqd.SelectSingleNode("//div[@id='searchResultsNumber']");


            var resSplit = numbers.InnerText.Split(' ');

            return int.Parse(resSplit[resSplit.Length - 2]);
        }

        private static List<YellowPagesSearchPage> GetSearchPages(HtmlNode document, string normalizedUrl)
        {
            var list = new List<YellowPagesSearchPage>();

            var pagination = document.SelectSingleNode("//html//body//div[@id='contentMainSearchResults']//section[@class='pagination']");

            if (pagination == null)
            {
                list.Add(new YellowPagesSearchPage()
                {
                    Url = normalizedUrl
                });

                return list;
            }

            var pageList = pagination.SelectNodes("//ul[@class='right']//li//a");

            if (pageList == null)
            {
                list.Add(new YellowPagesSearchPage()
                {
                    Url = normalizedUrl
                });

                return list;
            }

            foreach (var item in pageList)
            {
                var isCurrent = item.Attributes["class"] != null && item.Attributes["class"].Value == "current";

                var uri = new Uri(normalizedUrl);

                var begin = string.Format("http://{0}", uri.Host);

                if (isCurrent)
                {
                    var page = new YellowPagesSearchPage()
                    {
                        Url = normalizedUrl
                    };

                    list.Add(page);
                }
                else
                {
                    if (!item.InnerHtml.Contains("Next"))
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

        private static List<YellowPagesFilter> GetAdditionalFilters(HtmlNode document)
        {
            var filterList = new List<YellowPagesFilter>();

            var filterContainer = document.SelectSingleNode(
                "//html//body//div[@id='contentMainSearchResults']//section[@id='filterModuleSearchResults']"); //div[@data-name='filter-container']

            if (filterContainer == null)
            {
                return new List<YellowPagesFilter>();
            }

            var filters = filterContainer.SelectNodes("//div[@class='filterColumn']//div[@class='filterBlock']//select");

            HtmlNode categories = null;

            foreach (var f in filters)
            {
                var fi = new YellowPagesFilter();

                fi.Query = f.Attributes["id"].Value;

                var optGroup = f.ChildNodes["optgroup"];

                fi.Name = optGroup.Attributes["label"].Value;

                var options = optGroup.Descendants("option");

                var list = new List<NameValueAndUrl>();

                foreach (var cn in options)
                {
                        var nvu = new NameValueAndUrl()
                        {
                            Display = cn.NextSibling.InnerText.Replace("&amp;", "&"),
                            Value = cn.Attributes["value"].Value
                        };

                        list.Add(nvu);
                }

                fi.Values = list.ToArray();

                filterList.Add(fi);
            }

            return filterList;
        }
    }
}
