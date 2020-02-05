using IntroShop.Main.Interfaces;
using IntroShop.Main.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntroShop.Main.MockData
{
    public class MockMotherBoardCategory : IMotherBoardCategory
    {
        public IEnumerable<MotherBoardCategory> AllMotherBoardCategories
        {
            get
            {
                return new List<MotherBoardCategory>
                {
                    new MotherBoardCategory { categoryName = "Flagman", categoryDescription = "!!!!!!!!!!!!!!!!" },
                    new MotherBoardCategory { categoryName = "Budget", categoryDescription  = "@@@@@@@@@@@@@@@@" },
                    new MotherBoardCategory { categoryName = "Flagman", categoryDescription  = "!!!!!!!!!!!!!!!!" }
                };

            }
        }
    }
}
