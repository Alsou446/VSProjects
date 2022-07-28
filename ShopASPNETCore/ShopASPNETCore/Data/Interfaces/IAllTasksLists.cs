using ShopASPNETCore.Data.Models;
using System.Collections.Generic;

namespace ShopASPNETCore.Data.Interfaces
{
    public interface IAllTasksLists
    {
        IEnumerable<TasksList> AllTasksLists { get; }
    }
}
