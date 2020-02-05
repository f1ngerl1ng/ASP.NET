using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IntroShop.Main.Interfaces;
using IntroShop.Main.Models;

namespace IntroShop.Main.MockData
{
    public class MockSsdCategory : ISsdCategory
    {
        public IEnumerable<SsdCategory> AllSsdCategories
        {
            get
            {
                return new List<SsdCategory>{
                    new SsdCategory { categoryName = "Intel", categoryDescription = "1111" },
                    new SsdCategory { categoryName = "Apacer", categoryDescription = "2222" },
                    new SsdCategory { categoryName = "Kingstom", categoryDescription = "3333" },
                    new SsdCategory { categoryName = "Samsung", categoryDescription = "4444" }
                };
            }
        }
    }

}
