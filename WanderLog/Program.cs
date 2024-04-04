// ASP.NEt Pipeline
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace WanderLog
{
    
    public class Program
    {
        public static void Main(string[] args)
        {
            WebApplicationBuilder builder = WebApplication.CreateBuilder(args);
            
            builder.Services.AddControllersWithViews();

            WebApplication app = builder.Build();

            app.UseHttpsRedirection();

            app.UseRouting();

            // After creating the wwwroot and wwwroot/img directory and store images in the img, the below is needed to be able to render images
            app.UseStaticFiles();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}"
            );

            app.Run();
        }   
    }
}