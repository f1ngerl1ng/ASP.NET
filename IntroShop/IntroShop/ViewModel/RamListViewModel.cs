using IntroShop.Main;
using IntroShop.Main.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntroShop.ViewModel
{
    public class RamListViewModel
    {
        public IEnumerable<RAM> allRams { get; set; }
        public string currentCategory { get; set; }
    }
}
