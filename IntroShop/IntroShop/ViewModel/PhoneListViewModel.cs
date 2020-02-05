using IntroShop.Main;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntroShop.ViewModel
{
    public class PhoneListViewModel
    {
        public IEnumerable<Phone> allPhones { get; set; }
        public string currentCategory { get; set; }
    }
}
