using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YPScraper
{
    public class YellowPagesBusinessParser
    {
        public static YellowPagesBusinessListing Parse(HtmlNode document, YellowPagesBusinessListing business)
        {
            business = YellowPagesBusinessParser.GetAddressInformation(document, business);

            business = YellowPagesBusinessParser.GetContantInformation(document, business);

            return business;
        }

        private static YellowPagesBusinessListing GetContantInformation(HtmlNode document, YellowPagesBusinessListing business)
        {
            var ds = document.SelectSingleNode("//html//body//div[@id='contentContainerDetailsPage']//div[@class='gridContainer']//div[@class='contentMainFull']//div[@id='detailSectionPrimary']");

            if (ds == null)
            {
                return business;
            }

            var contactSection = ds.SelectSingleNode(
                string.Format("{0}//div[@class='columnPrimary']//section[@id='businessDetailsPrimary']//div[contains(@class,'listItemActionsPrimary')]", ds.XPath));

            if (contactSection == null)
            {
                return business;
            }

            var phone = contactSection.SelectSingleNode(string.Format("{0}//meta[@itemprop='telephone']", contactSection.XPath));

            var email = contactSection.SelectSingleNode(string.Format("{0}//meta[@itemprop='email']", contactSection.XPath));

            var website = contactSection.SelectSingleNode(string.Format("{0}//a[@itemprop='url']", contactSection.XPath));

            var fax = contactSection.SelectSingleNode(string.Format("{0}//div[contains(@class,'listItemActionsSecondary')]//meta[@itemprop='faxNumber']", contactSection.XPath));

            // TODO Get additional numbers

            business.Phone = phone == null ? string.Empty : phone.Attributes["content"].Value;
            business.FaxNumber = fax == null ? string.Empty : fax.Attributes["content"].Value;
            business.Email = email == null ? string.Empty : email.Attributes["content"].Value;
            business.Website = website == null ? string.Empty : website.Attributes["href"].Value;

            return business;
        }

        private static YellowPagesBusinessListing GetAddressInformation(HtmlNode document, YellowPagesBusinessListing business)
        {
            var ds = document.SelectSingleNode("//html//body//div[@id='contentContainerDetailsPage']//div[@class='gridContainer']//div[@class='contentMainFull']//div[@id='detailSectionPrimary']");

            if (ds == null)
            {
                return business;
            }

            var addressSection = ds.SelectSingleNode(
                string.Format("{0}//div[@class='columnPrimary']//section[@id='businessDetailsPrimary']//div[@class='businessNameLocationRating']//div[contains(@class,'itemAddress')]//span[@itemprop='address']", ds.XPath));

            if (addressSection == null)
            {
                return business;
            }

            var streetAddress = addressSection.SelectSingleNode(string.Format("{0}//span[@itemprop='streetAddress']", addressSection.XPath));

            var country = addressSection.SelectSingleNode(string.Format("{0}//span[@itemprop='addressCountry']//span[@itemprop='name']", addressSection.XPath));

            var region = addressSection.SelectSingleNode(string.Format("{0}//span[@itemprop='addressRegion']", addressSection.XPath));

            var locality = addressSection.SelectSingleNode(string.Format("{0}//span[@itemprop='addressLocality']", addressSection.XPath));
                        
            business.StreetAddress = streetAddress == null ? string.Empty : streetAddress.InnerText;
            business.Country = country == null ? string.Empty : country.Attributes["content"].Value;
            business.Region = region == null ? string.Empty : region.Attributes["content"].Value;
            business.Locality = locality == null ? string.Empty : locality.Attributes["content"].Value;

            return business;
        }
    }
}
