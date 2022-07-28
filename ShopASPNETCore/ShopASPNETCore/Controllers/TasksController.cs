using Microsoft.AspNetCore.Mvc;
using ShopASPNETCore.Data.Interfaces;
using ShopASPNETCore.Data.Models;
using ShopASPNETCore.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace ShopASPNETCore.Controllers
{
    public class TasksController : Controller
    {
        private readonly IAllTasks _allTasks;
        private readonly IAllTasksLists _allTasksLists;

        public TasksController(IAllTasks tasks, IAllTasksLists lists)
        {
            _allTasks = tasks;
            _allTasksLists = lists;
        }

        [Route("Tasks/ResultList")]
        [Route("Tasks/ResultList/{tskListName}")]

        public ViewResult ResultList (string tskListName)
        {
            string _tskListName = tskListName;
            IEnumerable<Task> tasks = null;
            string currList = "";
            if(string.IsNullOrEmpty(tskListName))
            {
                tasks = _allTasks.AllTasks.OrderBy(i => i.Id);
            }
            else
            {
                tasks = _allTasks.AllTasks.Where(i => i.TasksList.ListName.Equals(tskListName)).OrderBy(i => i.Id);
            }


            ViewBag.Title = "Страница с задачами";
            SpisokViewModel spsokViewModel = new SpisokViewModel();
            spsokViewModel.allTasks = _allTasks.AllTasks;
            spsokViewModel.curList = "Задачи";
            return View(spsokViewModel);
        }
    }
}
