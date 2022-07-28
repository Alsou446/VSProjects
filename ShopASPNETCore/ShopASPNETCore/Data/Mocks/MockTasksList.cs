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
                new TasksList { Id = 1, Name = "Задачи на понедельник"},
                new TasksList { Id = 2, Name = "Задачи на вторник"},
                new TasksList { Id = 3, Name = "Задачи на среду"},
                new TasksList { Id = 4, Name = "Задачи на четверг"}};
            }
        }

    }
}
