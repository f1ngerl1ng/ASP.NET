using IntroShop.Main.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntroShop.Main.MockData
{
    public class MockPhoneCategory : IPhoneCategory
    {
        public IEnumerable<PhoneCategory> AllPhoneCategories
        {
            get
            {
                return new List<PhoneCategory>
                {
                    new PhoneCategory { categoryName  = "Flagman", categoryDescription = "Phone with hight price and extra functions" },
                    new PhoneCategory { categoryName  = "Budget", categoryDescription  = "Phone with low price without extra fubctions" },
                };

            }
        }
    }
}
