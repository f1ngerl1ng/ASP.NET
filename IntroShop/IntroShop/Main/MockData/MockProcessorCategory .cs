using IntroShop.Main.Interfaces;
using IntroShop.Main.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntroShop.Main.MockData
{
    public class MockProcessorCategory : IProcessorCategory
    {
        public IEnumerable<ProcessorCategory> AllProcessorCategories
        {
            get
            {
                return new List<ProcessorCategory>
                {
                    new ProcessorCategory { categoryName = "Flagman", categoryDescription = "!!!!!!!!!!!!!!!!" },
                    new ProcessorCategory { categoryName = "Budget", categoryDescription  = "@@@@@@@@@@@@@@@@" },
                    new ProcessorCategory { categoryName = "Flagman", categoryDescription  = "!!!!!!!!!!!!!!!!" }
                };

            }
        }
    }
}
