using IntroShop.Main.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntroShop.Main.MockData
{
    public class MockVideoCardCategory : IVideoCardCategory
    {
        public IEnumerable<VideoCardCategory> AllVideoCardCategories
        {
            get
            {
                return new List<VideoCardCategory>
                {
                    new VideoCardCategory { categoryName = "Flagman", categoryDescription = "!!!!!!!!!!!!!!!!" },
                    new VideoCardCategory { categoryName = "Budget", categoryDescription  = "@@@@@@@@@@@@@@@@" },
                };

            }
        }
    }
}
