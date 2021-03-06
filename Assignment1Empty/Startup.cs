using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Assignment1Empty
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddControllersWithViews();
            services.AddSession();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();

            app.UseRouting();

            app.UseSession();

            app.UseEndpoints(endpoints =>
            {

                endpoints.MapControllerRoute(
                    name: "GuessingGame",
                    pattern: "GuessingGame",
                    new { controller = "GuessingGame", action = "guessingGameView" });

                endpoints.MapControllerRoute(
                    name: "FeverCheck",
                    //pattern: "/{controller}/{action}/{id?}",
                    //new { controller = "Doctor", action = "Temperature" });
                    pattern: "FeverCheck",
                    new { controller = "Doctor", action = "Temperature" });

                endpoints.MapControllerRoute(
                    name: "Default",
                    pattern: "/{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
