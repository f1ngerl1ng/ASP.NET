using IntroShop.Main.Interfaces;
using IntroShop.Main.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntroShop.Main.MockData
{
    public class MockMotherBoard : IAllMotherBoard
    {
        private readonly IMotherBoardCategory _categoryMotherBoard = new MockMotherBoardCategory();
        public IEnumerable<MotherBoard> MotherBoards
        {
            get
            {
                return new List<MotherBoard>
                {
                    new MotherBoard
                    {
                        name = "Asus Prime",
                        description = "B360-Plus (s1151, Intel B360, PCI-Ex16)",
                        img = "/img/shop/asus_prime_b360.jpg",
                        price = 2690,
                        Category = _categoryMotherBoard.AllMotherBoardCategories.First()
                    },
                     new MotherBoard
                    {
                        name = "Asus Prime",
                        description = "B450M-A (sAM4, AMD B450, PCI-Ex16)",
                        img = "/img/shop/asus_prime_b450m.jpg",
                        price = 2020,
                        Category = _categoryMotherBoard.AllMotherBoardCategories.First()
                    },
                    new MotherBoard
                    {
                        name = "Asus ROG ",
                        description = "Strix Z390-E Gaming (s1151, Intel Z390, PCI-Ex16)",
                        img = "/img/shop/asus_rog_strix_z390.jpg",
                        price = 6160,
                        Category = _categoryMotherBoard.AllMotherBoardCategories.Last()
                    }
                };
            }
        }
    }
}