using IntroShop.Main.Interfaces;
using IntroShop.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace IntroShop.Controlles
{
    public class MotherBoardController : Controller
    {
        private readonly IAllMotherBoard _allProcessor;
        private readonly IMotherBoardCategory _allProcessorCategories;
        public MotherBoardController(IAllMotherBoard IAllProcessors, IMotherBoardCategory IProcessorCat)
        {
            _allProcessor = IAllProcessors;
            _allProcessorCategories = IProcessorCat;
        }

        public ViewResult List()
        {
            ViewBag.Title = "MotherBoard";
            MotherBoardListViewModel obj = new MotherBoardListViewModel();
            obj.allMotherBoards = _allProcessor.MotherBoards;
            obj.currentCategory = "Best MotherBoard";

            return View(obj);
        }
    }
}
