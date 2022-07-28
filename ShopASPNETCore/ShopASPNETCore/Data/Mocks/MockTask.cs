using ShopASPNETCore.Data.Interfaces;
using ShopASPNETCore.Data.Models;
using System.Collections.Generic;
using System.Linq;

namespace ShopASPNETCore.Data.Mocks
{
    public class MockTask : IAllTasks
    {
        private readonly IAllTasksLists _allTasksLists = new MockTasksList();
        public IEnumerable<Task> AllTasks
        {
            get
            {
                return new List<Task>
                { 
                new Task { Text = "P1", DeadlineDate = System.DateTime.Now, Checked = false, TasksList =  _allTasksLists.AllTasksLists.ElementAt(0)},
                new Task { Text = "P2", DeadlineDate = System.DateTime.Now, Checked = false, TasksList =  _allTasksLists.AllTasksLists.ElementAt(0)},
                new Task { Text = "P3", DeadlineDate = System.DateTime.Now, Checked = false, TasksList =  _allTasksLists.AllTasksLists.ElementAt(0)},
                new Task { Text = "P4", DeadlineDate = System.DateTime.Now, Checked = false, TasksList =  _allTasksLists.AllTasksLists.ElementAt(0)},
                new Task { Text = "V1", DeadlineDate = System.DateTime.Now, Checked = false, TasksList =  _allTasksLists.AllTasksLists.ElementAt(1)},
                new Task { Text = "S1", DeadlineDate = System.DateTime.Now, Checked = false, TasksList =  _allTasksLists.AllTasksLists.ElementAt(2)},
                new Task { Text = "S2", DeadlineDate = System.DateTime.Now, Checked = false, TasksList =  _allTasksLists.AllTasksLists.ElementAt(2)},
                new Task { Text = "Ch1", DeadlineDate = System.DateTime.Now, Checked = false, TasksList = _allTasksLists.AllTasksLists.ElementAt(3)}
                };
            }

            set
            {

            }
        }

        public Task GetObjectTask(int taskId)
        {
            throw new System.NotImplementedException();
        }
    }
}
