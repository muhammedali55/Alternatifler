using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using AlternatiflerCore.Models;

namespace AlternatiflerCore
{
    public class Startup
    {

        public Startup(IConfiguration configuration) {
            Configuration = configuration;
        }
       
        public IConfiguration Configuration { get; }
        
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddRazorPages();
            services.AddDbContext<dbalternatifContext>();
            services.AddHttpClient();
           
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else {
                app.UseExceptionHandler("/Error");
                
                app.UseHsts();
            }
            app.UseRouting();
            app.UseStaticFiles();
         
            app.UseEndpoints(
             endpoints =>
             endpoints.MapControllerRoute(
                   name: "default",
                   pattern: "{controller=Categori}/{action=Index}/{ad?}")
         );
        }
    }
}
