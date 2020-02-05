using IntroShop.Main.Interfaces;
using IntroShop.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace IntroShop.Controlles
{
    public class ProcessorController : Controller
    {
        private readonly IAllProcessor _allProcessor;
        private readonly IProcessorCategory _allProcessorCategories;
        public ProcessorController(IAllProcessor IAllProcessors, IProcessorCategory IProcessorCat)
        {
            _allProcessor = IAllProcessors;
            _allProcessorCategories = IProcessorCat;
        }

        public ViewResult List()
        {
            ViewBag.Title = "Processor";
            ProcessorListViewModel obj = new ProcessorListViewModel();
            obj.allProcessor = _allProcessor.Processors;
            obj.currentCategory = "Best phone";

            return View(obj);
        }
    }
}
