using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YPScraper
{
    public class CSVBuilder
    {
        public string CreateCSVFile(List<YellowPagesBusinessListing> listings)
        {
            var csvString = string.Empty;

            var pNames = this.GetPropertyNames(typeof(YellowPagesBusinessListing));

            csvString += string.Format(
                "\"{0}\"\r\n", 
                pNames.Aggregate((a, b) => 
                    string.Format(
                        "{0}\",\"{1}", 
                        a, 
                        b)));

            foreach (var business in listings)
            {
                int counter = 0;

                var pString = string.Empty;

                foreach (var property in pNames)
                {
                    if (counter != 0)
                    {
                        pString += ", ";
                    }

                    pString += "\"" + this.GetValue(property, business) + "\"";

                    counter++;
                }

                csvString += pString + "\r\n";
                //csvString += string.Format(
                //    "\"{0}\"\r\n",
                //    pNames.Aggregate((a, b) =>
                //        string.Format(
                //            "{0}\",\"{1}",
                //            this.GetValue(a, business),
                //            this.GetValue(b, business))));
            }

            return csvString;
        }

        public string GetValue(string name, object listing)
        {
            var type = listing.GetType();

            var property = type.GetProperty(name);

            if (property == null)
            {
                return string.Empty;
            }

            var res = property.GetValue(listing, null);

            var resultString = res == null ? string.Empty : (string)res;

            resultString.Replace("\r\n", "").Replace("\"", "\"\"").Replace("\r", "").Replace("\n", "");

            return resultString;
        }

        public List<string> GetPropertyNames(Type t)
        {
            var pList = new List<string>();

           var properties = t.GetProperties();

           foreach (var p in properties)
           {
               if (p.PropertyType == typeof(String) || p.PropertyType == typeof(string))
               {
                   pList.Add(p.Name);
               }
           }

           return pList;
        }
    }
}
