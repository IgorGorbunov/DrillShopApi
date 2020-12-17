using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using DrillShopApi.Common.Swagger;
using DrillShopApi.Services.Bootstrap;
using DrillShopApi.Services.Services;
using DrillShopApi.DAL.Bootstrap;
using DrillShopApi.Controllers;
using DrillShopApi.Repositories;
using DrillShopApi.Repositories.Bootstrap;
using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;


namespace DrillShopApi
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
            services.AddCors();
            services.ConfigureDb(Configuration);
            services.ConfigureRepositories();
            services.AddControllers();
            services.ConfigureServices();
            services.AddAutoMapper(
                typeof(DrillRepository).GetTypeInfo().Assembly,
                typeof(DrillsController).GetTypeInfo().Assembly,
                typeof(ShopRepository).GetTypeInfo().Assembly,
                typeof(ShopsController).GetTypeInfo().Assembly,
                typeof(ProviderRepository).GetTypeInfo().Assembly,
                typeof(ProvidersController).GetTypeInfo().Assembly,
                typeof(WarehouseRepository).GetTypeInfo().Assembly,
                typeof(WarehousesController).GetTypeInfo().Assembly
                );
            services.ConfigureSwagger();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseCors(x => x.WithOrigins("https://localhost:5001"));
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            app.UseCors();
            app.UseOpenApi();
            app.UseSwaggerUi3();
        }
    }
}
