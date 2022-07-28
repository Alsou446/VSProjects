using Microsoft.AspNetCore.Mvc;
using ShopASPNETCore.Data.Interfaces;
using ShopASPNETCore.ViewModels;
using System.Collections.Generic;

namespace ShopASPNETCore.Controllers
{
    public class HomeController : Controller
    {
        private IAllTasksLists _tskRep;

        public HomeController (IAllTasksLists tskRep)
        {
            _tskRep = tskRep;
        }

        public ViewResult Index()
        {
            var homeLists = new HomeViewModel
            {
                allLists = _tskRep.AllTasksLists
            };
            return View(homeLists);
        }
    }
}
