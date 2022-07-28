using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopASPNETCore.Data.Models
{
    public class TasksList
    {
        public int Id { get; set; }
        public string ListName { get; set; }

        public string Name { get; set; }
        public List<Task> Tasks { get; set; }
    }
}
