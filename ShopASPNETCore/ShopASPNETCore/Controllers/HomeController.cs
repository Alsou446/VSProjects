using Microsoft.AspNetCore.Mvc;
using ShopASPNETCore.Data;
using ShopASPNETCore.Data.Interfaces;
using ShopASPNETCore.Data.Models;
using ShopASPNETCore.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ShopASPNETCore.Controllers
{
    public class HomeController : Controller
    {
        private IAllTasksLists _tskRep;
        private readonly AppDBContent _appDBContent;

        public HomeController (IAllTasksLists tskRep, AppDBContent appDBContent)
        {
            _tskRep = tskRep;
            _appDBContent = appDBContent;
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
