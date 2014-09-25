using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YPScraper
{
    public class YellowPagesFilter
    {
        public string Name { get; set; }

        public string Query { get; set; }

        public NameValueAndUrl[] Values { get; set; }
    }
}
