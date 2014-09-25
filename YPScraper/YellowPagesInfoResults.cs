using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YPScraper
{
    public class YellowPagesInfoResults
    {
        public List<YellowPagesFilter> AdditionalFilters { get; set; }

        public List<YellowPagesSearchPage> SearchPages { get; set; }

        public bool Empty { get; set; }

        public int Results { get; set; }
    }
}
