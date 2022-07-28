using Microsoft.EntityFrameworkCore;
using ShopASPNETCore.Data.Interfaces;
using ShopASPNETCore.Data.Models;
using System.Collections.Generic;
using System.Linq;

namespace ShopASPNETCore.Data.Repository
{
    public class TaskRepository : IAllTasks
    {
        private readonly AppDBContent _content;

         public TaskRepository(AppDBContent _content)
        {
            this._content = _content;
        }

        public IEnumerable<Task> AllTasks => _content.Task.Include(c => c.TasksList);

        public Task GetObjectTask(int taskId) => _content.Task.FirstOrDefault(c => c.Id == taskId);
    }
}
