using IntroShop.Main.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntroShop.Main.Repository
{
    public class CategoryRepository : IPhoneCategory
    {
        private readonly DBContent dbContent;
        public CategoryRepository(DBContent dbContent)
        {
            this.dbContent = dbContent;
        }
        public IEnumerable<PhoneCategory> AllPhoneCategories => dbContent.phoneCategory;

    }
}
