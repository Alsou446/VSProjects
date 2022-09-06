using Microsoft.AspNetCore.Mvc;
using ShopASPNETCore.Data;
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
        private readonly AppDBContent _appDBContent;

        public TasksController(IAllTasks tasks, IAllTasksLists lists, AppDBContent appDBContent)
        {
            _allTasks = tasks;
            _allTasksLists = lists;
            _appDBContent = appDBContent;
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
                curList = currList,
            };

             return View(tskObj);
        }

        [HttpGet]
        [Route("Tasks/AddTask")]
        public ViewResult AddTask()
        {
            return View("AddTask");
        }

        [HttpPost]
        public ViewResult AddTask(Task task, TasksList curlist)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            else
            {
                task.TasksList = curlist;
                _appDBContent.Task.Add(task);

                _appDBContent.SaveChanges();


                var resultList = new SpisokViewModel
                {
                    allTasks = _allTasks.AllTasks.OrderBy(i => i.Id)
                };
                return View("~/Views/Tasks/ResultList.cshtml", resultList);
            }
        }
    }
}
