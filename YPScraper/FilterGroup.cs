using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YPScraper
{
    public class FilterGroup
    {
        public string Name { get; set; }

        public List<FilterControl> Filters { get; set; }
    }
}
