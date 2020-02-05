using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntroShop.Main
{
    public class DBObjects
    {
        public static void Initial(DBContent content)
        {
            if (!content.phoneCategory.Any())
            {
                content.phoneCategory.AddRange(Categories.Select(c => c.Value));
            }
            if (!content.Phone.Any())
            {
                content.AddRange(
                    new Phone
                    {
                        name = "Samsung S10",
                        description = "Экран (5.8\", Dynamic AMOLED, 2280x1080)/ Samsung Exynos 9820 (2 x 2.7 ГГц + 2 x 2.3 ГГц + 4 x 1.9 ГГц)/ двойная основная камера: 12 Мп + 16 Мп/ фронтальная 10 Мп/ RAM 6 ГБ/ 128 ГБ встроенной памяти + microSD (до 512 ГБ)/ 3G/ LTE/ GPS/ A-GPS/ ГЛОНАСС/ BDS/ поддержка 2х SIM-карт (Nano-SIM)/ Android 9.0 (Pie) / 3100 мА*ч",
                        img = "/img/samsung_galaxy_s10_6_128_gb.jpg",
                        price = 23000,
                        Category = Categories["Flagman"]
                    },
                    new Phone
                    {
                        name = "Nokia 3310",
                        description = "Nokia 3310 — двухдиапазонный (GSM 900/1800) сотовый телефон фирмы Nokia. Выпущен в четвёртом квартале 2000 года. Nokia 3310 — одна из самых удачных моделей в истории: было продано около 126 миллионов аппаратов.",
                        img = "/img/nokia_3310.jpg",
                        price = 666,
                        Category = Categories["Budget"]
                    }
                    );
            }
            content.SaveChanges();
        }

        private static Dictionary<string, PhoneCategory> category;
        public static Dictionary<string, PhoneCategory> Categories
        {
            get
            {
                if (category == null)
                {
                    var list = new PhoneCategory[]
                        {
                            new PhoneCategory { categoryName = "Flagman", categoryDescription = "Phone with hight price and extra functions" },
                        new PhoneCategory { categoryName = "Budget", categoryDescription = "Phone with low price without extra fubctions" }
                        };
                    category = new Dictionary<string, PhoneCategory>();
                    foreach (PhoneCategory item in list)
                    {
                        category.Add(item.categoryName, item);
                    }

                }

                return category;
            }
        }
    }
}
