using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.VisualBasic;
using ToDo.App.Tasks.Services;
using ToDo.BusinessObjects;
using ToDo.Configurations;

namespace ToDo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            //get configuation data from appsettings json
            var config = builder.Configuration.Get<AppConfiguration>();

            //inject configurations
            builder.Services.AddSingleton(config.Database);
            builder.Services.AddScoped<ITaskService, TaskService>();

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            //injected dbcontext service
            builder.Services.AddDbContextFactory<Context>(optionsaction => optionsaction.UseSqlServer(config.Database.ConnectionString));
            //builder.Services.AddScoped(p => p.GetRequiredService<IDbContextFactory<Context>>().CreateDbContext());

            // application get build 
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
