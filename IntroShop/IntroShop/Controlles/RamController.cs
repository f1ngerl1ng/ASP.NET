using IntroShop.Main.Interfaces;
using IntroShop.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace IntroShop.Controlles
{
    public class RamController : Controller
    {
        private readonly IAllRAM _allRAMs;
        private readonly IRamCategory _allRamCategories;
        public RamController(IAllRAM IAllRAMs, IRamCategory IRamCat)
        {
            _allRAMs = IAllRAMs;
            _allRamCategories = IRamCat;
        }

        public ViewResult List()
        {
            ViewBag.Title = "RAM";
           RamListViewModel obj = new RamListViewModel();
            obj.allRams = _allRAMs.RAMs;
            obj.currentCategory = "Best phone";

            return View(obj);
        }
    }
}
