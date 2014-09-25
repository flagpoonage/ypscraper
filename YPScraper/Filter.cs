using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YPScraper
{
    public class Filter
    {
        public string URL { get; set; }

        public string Name { get; set; }

        public string Value { get; set; }

        public Filter(YellowPagesFilter filter, string value)
        {
            foreach (var val in filter.Values)
            {
                if (val.Display == value)
                {
                    value = val.Url;
                    break;
                }
            }

            this.Name = filter.Name;
            this.URL = string.Format("{0}={1}", filter.Query, value);
            this.Value = value;
        }
    }
}
