using Microsoft.EntityFrameworkCore;
using ShopASPNETCore.Data.Interfaces;
using ShopASPNETCore.Data.Models;
using System.Collections.Generic;

namespace ShopASPNETCore.Data.Repository
{
    public class TasksListRepository : IAllTasksLists
    {
        private readonly AppDBContent _content;

        public TasksListRepository(AppDBContent _content)
        {
            this._content = _content;
        }

        public IEnumerable<TasksList> AllTasksLists => _content.TaskList.Include(c => c.Tasks);
    }
}
