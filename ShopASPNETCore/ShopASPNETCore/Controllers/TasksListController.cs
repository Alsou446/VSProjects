﻿using Microsoft.AspNetCore.Mvc;
using ShopASPNETCore.Data;
using ShopASPNETCore.Data.Interfaces;
using ShopASPNETCore.Data.Models;
using ShopASPNETCore.ViewModels;
using System.Linq;

namespace ShopASPNETCore.Controllers
{
    public class TasksListController : Controller
    {
        private readonly AppDBContent _appDBContent;

        private IAllTasksLists _tskRep;

        public TasksListController (AppDBContent appDBContent, IAllTasksLists tskRep)
        {
            _appDBContent = appDBContent;
            _tskRep = tskRep;
        }

        [HttpGet]
        [Route("TasksList/AddList")]
        public ViewResult AddList()
        {
            return View("TasksList");
        }

        [HttpPost]
        public ViewResult AddList(TasksList tasksList)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            else
            {
                _appDBContent.TaskList.Add(tasksList);
                _appDBContent.SaveChanges();

                var homeLists = new HomeViewModel
                {
                    allLists = _tskRep.AllTasksLists
                };
                return View("~/Views/Home/Index.cshtml", homeLists); //сюда будет прилетать лист задач с формы TasksListAdd
            }
        }

        

        public ViewResult DelList(int id)
        {
            TasksList curList = _tskRep.AllTasksLists.FirstOrDefault(i => i.Id.Equals(id));
            _appDBContent.TaskList.Remove(curList);
            _appDBContent.SaveChanges();
            var homeLists = new HomeViewModel
            {
                allLists = _tskRep.AllTasksLists
            };
            return View("~/Views/Home/Index.cshtml", homeLists);
        }



    }
}
