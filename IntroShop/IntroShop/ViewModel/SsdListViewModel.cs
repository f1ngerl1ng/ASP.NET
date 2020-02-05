using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IntroShop.Main.Models;

namespace IntroShop.ViewModel
{
    public class SsdListViewModel
    {
        public IEnumerable<SSD> allSSDs { get; set; }
        public string currentCategory { get; set; }

    }
}
