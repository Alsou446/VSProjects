using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ShopASPNETCore.Data;
using ShopASPNETCore.Data.Interfaces;
using ShopASPNETCore.Data.Mocks;
using ShopASPNETCore.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopASPNETCore
{
    public class Startup
    {
        private IConfigurationRoot _confString;

        public Startup(IWebHostEnvironment hostEnv) //����������� ����������� � 
        {
            _confString = new ConfigurationBuilder().SetBasePath(hostEnv.ContentRootPath).AddJsonFile("dbsetings.json").Build();//��������� ������ �� �����

        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            //services.AddDbContext<AppDBContent>(option => option.UseSqlServer(_confString.GetConnectionString("DefaultConnection")));
            services.AddDbContext<AppDBContent>(option => option.UseSqlite(_confString.GetConnectionString("DefaultConnection")));
            services.AddMvc(option => option.EnableEndpointRouting = false);
            services.AddTransient<IAllTasks, TaskRepository>();
            services.AddTransient<IAllTasksLists, TasksListRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseDeveloperExceptionPage();
            app.UseStatusCodePages();
            app.UseStaticFiles();
            //app.UseMvcWithDefaultRoute();
            app.UseMvc(routes => 
            {
                routes.MapRoute(name: "default", template: "{controller=Home}/{action=Index}/{Id?}");
                routes.MapRoute(name: "curTasksList", template: "Tasks/ResultList/{tskListName?}");
                routes.MapRoute(name: "TasksListAdd", template: "TasksList/AddList");
            });

            //using (var scope = app.ApplicationServices.CreateScope())
            //{
            //    AppDBContent content = scope.ServiceProvider.GetRequiredService<AppDBContent>(); //����������� � ��
            //    DBObjects.Initial(content);
            //}
        }
    }
}
