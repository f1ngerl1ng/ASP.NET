using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IntroShop.Main.Interfaces;
using IntroShop.Main.Models;

namespace IntroShop.Main.MockData
{
    public class MockSSD : IAllSSD
    {
        private readonly ISsdCategory _categorySSD = new MockSsdCategory();
        public IEnumerable<SSD> SSDs
        {
            get
            {
                return new List<SSD>
                {
                    new SSD
                    {
                        name = "Samsung 860",
                        description = "Evo-Series 250GB 2.5\" SATA III V-NAND (MLC) (MZ-76E250BW)",
                        img = "/img/samsung.jpg",
                        price = 1299,
                        Category = _categorySSD.AllSsdCategories.First()
                    },
                    new SSD
                    {
                        name = "ADATA Ultimate",
                        description = "SU650 120GB 2.5\" SATA III 3D NAND TLC (ASU650SS-120GT-R)",
                        img = "/img/adata.jpg",
                        price = 689,
                        Category = _categorySSD.AllSsdCategories.Last()
                    },
                    new SSD
                    {
                        name = "Kingston SSD",
                        description = "HyperX Fury 3D 120GB 2.5\" SATAIII TLC (KC–S44120–6F)",
                        img = "/img/kingston.jpg",
                        price = 729,
                        Category = _categorySSD.AllSsdCategories.Last()
                    }
                };
            }
        }
    }
}
