﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XIVMarket.Models.XIVAPI
{
    public class ItemPagination
    {
        public int Page { get; set; }
        public object PageNext { get; set; }
        public object PagePrev { get; set; }
        public int PageTotal { get; set; }
        public int Results { get; set; }
        public int ResultsPerPage { get; set; }
        public int ResultsTotal { get; set; }
    }
}
