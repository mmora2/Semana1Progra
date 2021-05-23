using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Semana1
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/index", async context =>
                {
                    await context.Response.WriteAsync("Holi mundo! :)");
                });

                endpoints.MapGet("/page2", async context =>
                {
                    await context.Response.WriteAsync("Holi pagina 2!");
                });

                endpoints.MapGet("/page3", async context =>
                {
                    await context.Response.WriteAsync("Holi pagina 3!");
                });

                endpoints.MapGet("/page4", async context =>
                {
                    await context.Response.WriteAsync("Holi pagina 4!");
                });
            });
        }
    }
}
