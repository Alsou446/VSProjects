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
            //var allLists = _tskRep.AllTasksLists;
            //return View("Index2", allLists);

        }

        //public IActionResult DelList(Guid id)
        //{
        //    var listtasks = _tskRep.AllTasksLists.FirstOrDefault(i => i.Id.Equals(id));
        //    _appDBContent.TaskList.Remove(listtasks);
        //    _appDBContent.SaveChanges();
        //    return View("Index2");
        //}
    }
}
