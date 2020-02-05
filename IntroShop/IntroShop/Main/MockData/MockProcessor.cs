using IntroShop.Main.Interfaces;
using IntroShop.Main.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntroShop.Main.MockData
{
    public class MockProcessor : IAllProcessor
    {
        private readonly IProcessorCategory _categoryProcessor = new MockProcessorCategory();
        public IEnumerable<Processor> Processors
        {
            get
            {
                return new List<Processor>
                {
                    new Processor
                    {
                        name = "Intel Core i3-8100",
                        description = "3.6GHz/8GT/s/6MB (BX80684I38100) s1151 BOX",
                        img = "/img/shop/intel_core_i3_8100.jpg",
                        price = 3650,
                        Category = _categoryProcessor.AllProcessorCategories.First()
                    },
                     new Processor
                    {
                        name = "Intel Core i7-9700",
                        description = "3.0GHz/8GT/s/12MB (BX80684I79700) s1151 BOX",
                        img = "/img/shop/intel_core_i7_9700.jpg",
                        price = 10250,
                        Category = _categoryProcessor.AllProcessorCategories.First()
                    },
                    new Processor
                    {
                        name = "Intel Core i5-9400F",
                        description = "2.9GHz/8GT/s/9MB (BX80684I59400F) s1151 BOX",
                        img = "/img/shop/intel_core_i5_9400f.jpg",
                        price = 4356,
                        Category = _categoryProcessor.AllProcessorCategories.Last()
                    }
                };
            }
        }
    }
}