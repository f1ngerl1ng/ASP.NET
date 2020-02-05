﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntroShop.Main.Models
{
    public class ProcessorCategory
    {
        public int id { set; get; }
        public string categoryName { set; get; }
        public string categoryDescription { set; get; }
        public List<Processor> Processors { set; get; }
    }
}
