using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Dell.POC.ConfigurationSettings;
using Dell.POC.Repository.Interfaces;
using Dell.POC.Repository.Impl;
using Dell.POC.Services;
using Dell.POC.Models;
namespace Dell.POC.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;  
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            AddConfiguration(services);
            RegisterServices(services);
            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            app.UseSwagger();
            app.UseSwaggerUI(options => options.SwaggerEndpoint("/swagger/v2/swagger.json", "PlaceInfo Services"));
        }


        private void AddConfiguration(IServiceCollection services)
        {

            
            ConnectionString.ConfigureServices(
           
            Configuration.GetSection("ConnectionStrings").GetSection("").Value);

         

        }
        private void RegisterServices(IServiceCollection services)
        {

            services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v2", new Microsoft.OpenApi.Models.OpenApiInfo
                {
                    Title = "Dell Poc",
                    Version = "v2",
                    Description = "Dell POC",
                });
            });
            services.AddSingleton<IConfiguration>(Configuration);




            services.AddScoped<IEntityRepository, EntityRepository>();
          
            services.AddScoped<IEntitiyService, EntityService>();



        }
    }
}
