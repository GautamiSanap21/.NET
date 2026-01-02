using Microsoft.EntityFrameworkCore;
using MVC_EF_Filters_Sessions_WebAPI.Models;

namespace MVC_EF_Filters_Sessions_WebAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
            var app = builder.Build();

            builder.Services.AddDbContext<DataContext>(options =>
            {
                options.UseSqlServer("name=Data");
            });

            app.Run();
        }
    }
}
