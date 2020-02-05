using IntroShop.Main.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using IntroShop.ViewModel;

namespace IntroShop.Controlles
{
    public class VideoCardController : Controller
    {
        private readonly IAllVideoCard _allVideoCards;
        private readonly IVideoCardCategory _allVideoCardCategories;
        public VideoCardController(IAllVideoCard IAllVideoCards, IVideoCardCategory IVideoCardCat)
        {
            _allVideoCards = IAllVideoCards;
            _allVideoCardCategories = IVideoCardCat;
        }

        public ViewResult List()
        {
            ViewBag.Title = "VideoCard";
           VideoCardListViewModel obj = new VideoCardListViewModel();
            obj.allVideoCards = _allVideoCards.VideoCards;
            obj.currentCategory = "Best VideoCard";

            return View(obj);
        }
    }
}
