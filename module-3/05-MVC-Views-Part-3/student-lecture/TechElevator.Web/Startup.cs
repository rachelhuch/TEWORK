﻿using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TechElevator.Web.DAL;

namespace TechElevator.Web
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration.GetConnectionString;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            // TODO: Use Configuration to get a connection string to the database

            // TODO: Add Dependency Injection setup logic here for a Film DAO
            //Listen framework, anytime someone needs an IStarWarsDAO, I'm telling you 
            //create a StarWarsSqlDAO and give that to them 

            string connectionString = Configuration.GetConnectionString
            services.AddTransient<IStarWarsDAO, StarWarsSqlDAO>(x => new StarWarsSqlDAO(connectionString));

            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });

        }
    }
}
