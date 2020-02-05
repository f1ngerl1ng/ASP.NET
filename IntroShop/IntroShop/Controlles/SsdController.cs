using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using IntroShop.Main.Interfaces;
using IntroShop.ViewModel;

namespace IntroShop.Controllers
{
    public class SsdController : Controller
    {
        private readonly IAllSSD _allSSDs;
        private readonly ISsdCategory _allSsdCategories;

        public SsdController(IAllSSD iAllSSDs, ISsdCategory iSsdCategory)
        {
            _allSSDs = iAllSSDs;
            _allSsdCategories = iSsdCategory;
        }

        public ViewResult List()
        {
            ViewBag.Title = "SSD";
            SsdListViewModel obj = new SsdListViewModel();
            obj.allSSDs = _allSSDs.SSDs;
            obj.currentCategory = "Best category";

            return View(obj);
        }
    }
}