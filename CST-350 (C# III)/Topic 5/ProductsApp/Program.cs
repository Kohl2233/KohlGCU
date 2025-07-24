using ProductsApp.Models;
using ProductsApp.Services;

namespace ProductsApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            // Add Logging
            builder.Services.AddLogging();

            // Register Application Services
            builder.Services.AddScoped<IProductDAO, ProductDAO>();
            builder.Services.AddScoped<IProductService, ProductService>();

            // Register the ProductMapper with Constructor Properties
            builder.Services.AddSingleton<IProductMapper>(serviceProvider =>
            {
                string currencyFormat = "C";
                string dateFormat = "D";
                decimal taxRate = 0.08m;

                return new ProductMapper(currencyFormat, dateFormat, taxRate);
            });

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
