using Microsoft.EntityFrameworkCore;
using SIMSWebApp.DatabaseContext;
using SIMSWebApp.Interface;
using SIMSWebApp.Repositories;
using SIMSWebApp.Services;

namespace SIMSWebApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            // cau hinh ket noi toi sql
            builder.Services.AddDbContext<SIMSDbContext>(options => 
                options.UseSqlServer(builder.Configuration.GetConnectionString("default"))
            );
            builder.Services.AddScoped<IUserRepository, UserRepository>();
            builder.Services.AddScoped<UserService>();
            // Add services to the container.
            builder.Services.AddControllersWithViews();

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
                pattern: "{controller=Login}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
