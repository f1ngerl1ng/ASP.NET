using IntroShop.Main;
using IntroShop.Main.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntroShop.ViewModel
{
    public class MotherBoardListViewModel
    {
        public IEnumerable<MotherBoard> allMotherBoards { get; set; }
        public string currentCategory { get; set; }
    }
}
