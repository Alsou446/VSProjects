using Microsoft.AspNetCore.Mvc;
using ShopASPNETCore.Data;
using ShopASPNETCore.Data.Interfaces;
using ShopASPNETCore.Data.Models;
using ShopASPNETCore.ViewModels;

namespace ShopASPNETCore.Controllers
{
    public class TasksListAddController : Controller
    {
        private readonly AppDBContent _appDBContent;

        private IAllTasksLists _tskRep;

        public TasksListAddController (AppDBContent appDBContent, IAllTasksLists tskRep)
        {
            _appDBContent = appDBContent;
            _tskRep = tskRep;
        }

        [HttpGet]
        [Route("TasksListAdd/AddList")]
        public ViewResult AddList()
        {
            return View("TasksListAdd");
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



    }
}
