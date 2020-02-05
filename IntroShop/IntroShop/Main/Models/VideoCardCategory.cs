using IntroShop.Main.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntroShop.Main
{
    public class VideoCardCategory
    {
        public int id { set; get; }
        public string categoryName { set; get; }
        public string categoryDescription { set; get; }
        public List<VideoCard> VideoCards { set; get; }
    }
}
