using Microsoft.EntityFrameworkCore;
using ToDoListWebApp.Models;
using ToDoListWebApp.Services;

namespace ToDoListWebApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container. register dependecies.injection
            builder.Services.AddRazorPages();
            string connString = builder.Configuration.GetConnectionString("SqlConnString");
            builder.Services.AddDbContext<ToDoContext> (options => options.UseSqlServer (connString));
            builder.Services.AddScoped<ToDoServices>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapRazorPages();

            app.Run();
        }
    }
}