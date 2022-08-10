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
            TasksList currList = _allTasksLists.AllTasksLists.First(i => i.ListName.Equals(_tskListName));
            if(string.IsNullOrEmpty(tskListName))
            {
                tasks = _allTasks.AllTasks.OrderBy(i => i.Id);
            }
            else
            {
                //if (string.Equals("Monday", _tskListName, System.StringComparison.OrdinalIgnoreCase))
                    tasks = _allTasks.AllTasks.Where(i => i.TasksList.ListName.Equals(tskListName)).OrderBy(i => i.Id);
            }


            var tskObj = new SpisokViewModel
            {
                allTasks = tasks,
                curList = currList.Name,
            };


            ViewBag.Title = "Страница с задачами";
            //SpisokViewModel spsokViewModel = new SpisokViewModel();
            //spsokViewModel.allTasks = _allTasks.AllTasks;
            //spsokViewModel.curList = "Задачи";
            //return View(spsokViewModel);
             return View(tskObj);
        }
    }
}
