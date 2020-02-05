using IntroShop.Main.Interfaces;
using IntroShop.Main.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntroShop.Main.MockData
{
    public class MockRAM : IAllRAM
    {
        private readonly IRamCategory _categoryRAM = new MockRamCategory();
        public IEnumerable<RAM> RAMs
        {
            get
            {
                return new List<RAM>
                {
                    new RAM
                    {
                        name = "HyperX",
                        description = "DDR3-1600 8192MB PC3-12800 (Kit of 2x4096) FURY Red (HX316C10FRK2/8)",
                        img = "/img/shop/hyperx_hx316c10frk2_8.jpg",
                        price = 1070,
                        Category = _categoryRAM.AllRamCategories.First()
                    },
                    new RAM
                    {
                        name = "HyperX",
                        description = "DDR4-3000 16384MB PC4-24000 Predator RGB Black (HX430C15PB3A/16)",
                        img = "/img/shop/hyperx_hx426c16fb3k2.jpg",
                        price = 2800,
                        Category = _categoryRAM.AllRamCategories.First()
                    },
                    new RAM
                    {
                        name = "HyperX",
                        description = "DDR4-2666 16384MB PC4-21300 (Kit of 2x8192) Fury Black (HX426C16FB3K2/16)",
                        img = "/img/shop/hyperx_hx430c15pb3a.jpg",
                        price = 2150,
                        Category = _categoryRAM.AllRamCategories.Last()
                    }
                };
            }
        }
    }
}