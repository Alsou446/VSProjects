using System;

namespace ShopASPNETCore.Data.Models
{
    public class Task
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public bool Checked { get; set; }
        public DateTime DeadlineDate { get; set; }
        public int TasksListId { get; set; }
        public virtual TasksList TasksList { get; set; }

    }
}
