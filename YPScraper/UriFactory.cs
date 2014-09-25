using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YPScraper
{
    public class UriFactory
    {
        public const string BaseAddress = "http://yellow.co.nz/{0}/{1}{2}";

        public static string CreateUrl(string where, string what, string filterString)
        {
            return string.Format(BaseAddress, where, what, 
                string.IsNullOrEmpty(filterString) ? string.Empty : "?" + filterString);
        }
    }
}
