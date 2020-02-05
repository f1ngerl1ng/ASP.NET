using IntroShop.Main;
using IntroShop.Main.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntroShop.ViewModel
{
    public class VideoCardListViewModel
    {
        public IEnumerable<VideoCard> allVideoCards { get; set; }
        public string currentCategory { get; set; }
    }
}
