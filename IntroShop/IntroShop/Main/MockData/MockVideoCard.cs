using IntroShop.Main.Interfaces;
using IntroShop.Main.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntroShop.Main.MockData
{
    public class MockVideoCard : IAllVideoCard
    {
        private readonly IVideoCardCategory _categoryVideoCard = new MockVideoCardCategory();
        public IEnumerable<VideoCard> VideoCards
        {
            get
            {
                return new List<VideoCard>
                {
                    new VideoCard
                    {
                        name = "GeForce GTX 1050 Ti",
                        description = "GAMING X 4GB GDDR5 (128bit) (1354/7008) (DVI, HDMI, DisplayPort) (GTX 1050 TI GAMING X 4G)",
                        img = "/img/shop/msi_geforce_rtx_2080_ti_gaming_x_trio_11g.jpg",
                        price = 4299,
                        Category = _categoryVideoCard.AllVideoCardCategories.First()
                    },
                    new VideoCard
                    {
                        name = "Radeon RX 5700 XT",
                        description = "NITRO+ 8GB GDDR6 (256bit) (1770/14000) (2 х HDMI, 2 x DisplayPort) (11293-03-40G)",
                        img = "/img/shop/msi_gtx_1050_ti_gaming_x_4g.jpg",
                        price = 13629,
                        Category = _categoryVideoCard.AllVideoCardCategories.First()
                    },
                    new VideoCard
                    {
                        name = "GeForce RTX 2080 Ti",
                        description = "Gaming X Trio 11GB GDDR6 (352bit) (1350/14000) (USB Type-C, HDMI, 3 x DisplayPort) (RTX 2080 Ti Gaming X Trio 11G)",
                        img = "/img/shop/sapphire_11293_03_40g.jpg",
                        price = 33185,
                        Category = _categoryVideoCard.AllVideoCardCategories.Last()
                    }
                };
            }
        }
    }
}