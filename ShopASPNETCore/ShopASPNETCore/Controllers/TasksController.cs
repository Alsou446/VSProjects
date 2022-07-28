using Microsoft.AspNetCore.Mvc;
using ShopASPNETCore.Data.Interfaces;
using ShopASPNETCore.ViewModels;

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

        public ViewResult ResultList ()
        {
            ViewBag.Title = "Страница с задачами";
            SpisokViewModel spsokViewModel = new SpisokViewModel();
            spsokViewModel.allTasks = _allTasks.AllTasks;
            spsokViewModel.curList = "Задачи";
            return View(spsokViewModel);
        }
    }
}
