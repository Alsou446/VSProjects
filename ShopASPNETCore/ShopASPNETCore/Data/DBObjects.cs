using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using ShopASPNETCore.Data.Models;
using System.Collections.Generic;
using System.Linq;

namespace ShopASPNETCore.Data
{
    public class DBObjects
    { 
        public static void Initial(AppDBContent content)
        {

            if(!content.TaskList.Any())
            {
                content.TaskList.AddRange(TasksLists.Select(c => c.Value)); //Функция выбирает все объекты, берёт их значения и записывает в список AddRange
                //добавляем все списки задач
            }

            if(!content.Task.Any())
            {
                content.Task.AddRange(Tasks.Select(c => c.Value));
            }

            content.SaveChanges();
        }

        private static Dictionary<string, TasksList> tsklist;

        public static Dictionary<string, TasksList> TasksLists
        {
            get
            {
                if (tsklist == null)
                {
                    var list = new TasksList[]
                    {
                        new TasksList { Name = "Задачи на понедельник", ListName = "Monday"},
                        new TasksList { Name = "Задачи на вторник", ListName = "Tuesday"},
                        new TasksList { Name = "Задачи на среду", ListName = "Wednesday"},
                        new TasksList { Name = "Задачи на четверг", ListName = "Thursday"}
                    };

                    tsklist = new Dictionary<string, TasksList>();
                    foreach(TasksList el in list)
                    {
                        tsklist.Add(el.ListName, el);
                    }
                }

                return tsklist;
            }
        }

        private static Dictionary<string, Task> tsk;

        public static Dictionary<string, Task> Tasks
        {
            get
            {
                if(tsk == null)
                {
                    var list = new Task[]
                    {

                        new Task { Text = "Понедельник1", DeadlineDate = System.DateTime.Now, Checked = false, TasksList =  tsklist["Monday"]},
                        new Task { Text = "Понедельник2", DeadlineDate = System.DateTime.Now, Checked = false, TasksList =  tsklist["Monday"]},
                        new Task { Text = "Понедельник3", DeadlineDate = System.DateTime.Now, Checked = false, TasksList =  tsklist["Monday"]},
                        new Task { Text = "Понедельник4", DeadlineDate = System.DateTime.Now, Checked = false, TasksList =  tsklist["Monday"]},
                        new Task { Text = "Вторник1", DeadlineDate = System.DateTime.Now, Checked = false, TasksList =  tsklist["Tuesday"]},
                        new Task { Text = "Среда1", DeadlineDate = System.DateTime.Now, Checked = false, TasksList =  tsklist["Wednesday"]},
                        new Task { Text = "Среда2", DeadlineDate = System.DateTime.Now, Checked = false, TasksList =  tsklist["Wednesday"]},
                        new Task { Text = "Четверг1", DeadlineDate = System.DateTime.Now, Checked = false, TasksList = tsklist["Thursday"]}

                    };

                    tsk = new Dictionary<string, Task>();
                    foreach (Task el in list)
                    {
                        tsk.Add(el.Text, el);
                    }
                }
                return tsk;
            }
        }
    }

}
