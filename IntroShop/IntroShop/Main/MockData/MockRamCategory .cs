using IntroShop.Main.Interfaces;
using IntroShop.Main.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntroShop.Main.MockData
{
    public class MockRamCategory : IRamCategory
    {
        public IEnumerable<RamCategory> AllRamCategories
        {
            get
            {
                return new List<RamCategory>
                {
                    new RamCategory { categoryName = "Flagman", categoryDescription = "!!!!!!!!!!!!!!!!" },
                    new RamCategory { categoryName = "Budget", categoryDescription  = "@@@@@@@@@@@@@@@@" },
                    new RamCategory { categoryName = "Flagman", categoryDescription  = "!!!!!!!!!!!!!!!!" }
                };

            }
        }
    }
}
