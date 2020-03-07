using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlueDiamond.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace BlueDiamond
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            // dodanie komentarza
            services.AddTransient<DemoRepository>();
            services.AddMvc();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseStatusCodePages();
            app.UseStaticFiles();
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Product}/{action=List}");
            });
        }
    }
}
