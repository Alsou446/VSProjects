using ShopASPNETCore.Data.Models;
using System.Collections.Generic;

namespace ShopASPNETCore.Data.Interfaces
{
    public interface IAllTasks
    {
        IEnumerable<Task> AllTasks { get; }
        Task GetObjectTask (int taskId);
    }
}
