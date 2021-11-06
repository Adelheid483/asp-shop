using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using asp_shop.Data.Services;
using asp_shop.Data.Interfaces;

namespace asp_shop
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddTransient<ICars, CarsService>(); // worker interface + class realizing this interface
            services.AddTransient<ICategories, CategoriesService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseDeveloperExceptionPage(); // for displaying the page of mistakes
            app.UseStatusCodePages(); // for displaying page with codes 400-500
            app.UseStaticFiles(); // for displaying CSS, imgs and othe ststic files
            app.UseMvcWithDefaultRoute(); // for using default url-address if don't using controller and view
        }
    }
}
