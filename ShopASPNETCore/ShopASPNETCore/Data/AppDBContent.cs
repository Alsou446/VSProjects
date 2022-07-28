using Microsoft.EntityFrameworkCore;
using ShopASPNETCore.Data.Models;


namespace ShopASPNETCore.Data
{
    public class AppDBContent : DbContext
    {
        public AppDBContent(DbContextOptions<AppDBContent> options) : base(options) //конструктор по умолчанию, данные передаём в базовый конструктор
        {
            
        }

        public DbSet<Task> Task { get; set; } //все задачи

        public DbSet<TasksList> TaskList { get; set; } //все списки



    }
}
