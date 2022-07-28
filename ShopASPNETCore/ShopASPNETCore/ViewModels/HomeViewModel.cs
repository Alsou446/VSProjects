using ShopASPNETCore.Data.Models;
using System.Collections.Generic;

namespace ShopASPNETCore.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<TasksList> allLists { get; set; }
    }
}
