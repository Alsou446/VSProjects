using ShopASPNETCore.Data.Interfaces;
using ShopASPNETCore.Data.Models;
using System.Collections.Generic;

namespace ShopASPNETCore.Data.Mocks
{
    public class MockTasksList : IAllTasksLists
    {
        public IEnumerable<TasksList> AllTasksLists
        {
            get { return new List<TasksList> {
                new TasksList { Id = 1, ListName = "Задачи на понедельник"},
                new TasksList { Id = 2, ListName = "Задачи на вторник"},
                new TasksList { Id = 3, ListName = "Задачи на среду"},
                new TasksList { Id = 4, ListName = "Задачи на четверг"}};
            }
        }

    }
}
