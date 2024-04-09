using Microsoft.EntityFrameworkCore;
using Test4.DataFolder;

namespace Test4
{
    public class Program
    {
        public static IHostBuilder CreateHostBuilder(string[] args) =>
           Host.CreateDefaultBuilder(args)
               .ConfigureServices((hostContext, services) =>
               {
                   services.AddDbContext<SchoolDbContext>(options =>
                       options.UseSqlServer(hostContext.Configuration.GetConnectionString("DefaultConnection")));
                   services.AddControllersWithViews();
               });
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run(); CreateHostBuilder(args).Build().Run();

            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
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
