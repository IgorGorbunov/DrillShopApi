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
using DrillShopApi.Infrastructure;
using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using System.Text;
using Microsoft.OpenApi.Models;


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

            var jwtTokenConfig = Configuration.GetSection("jwtTokenConfig").Get<JwtTokenConfig>();
            services.AddSingleton(jwtTokenConfig);
            //add auth
            services.AddAuthentication(x =>
            {
                x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(x =>
            {
                // the authentication requires HTTPS for the metadata address or authority
                x.RequireHttpsMetadata = true;
                // saves the JWT access token in the current HttpContext,
                x.SaveToken = true;
                x.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = true,
                    ValidIssuer = jwtTokenConfig.Issuer,
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(jwtTokenConfig.Secret)),
                    ValidAudience = jwtTokenConfig.Audience,
                    ValidateAudience = true,
                    ValidateLifetime = true,
                    ClockSkew = TimeSpan.FromMinutes(1)
                };
            });
            services.AddSingleton<IJwtAuthManager, JwtAuthManager>();
            services.AddHostedService<JwtRefreshTokenCache>();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "JWT Auth Demo", Version = "v1" });

                var securityScheme = new OpenApiSecurityScheme
                {
                    Name = "JWT Authentication",
                    Description = "Enter JWT Bearer token **_only_**",
                    In = ParameterLocation.Header,
                    Type = SecuritySchemeType.Http,
                    Scheme = "bearer",
                    BearerFormat = "JWT",
                    Reference = new OpenApiReference
                    {
                        Id = JwtBearerDefaults.AuthenticationScheme,
                        Type = ReferenceType.SecurityScheme
                    }
                };
                c.AddSecurityDefinition(securityScheme.Reference.Id, securityScheme);
                c.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                    {securityScheme, new string[] { }}
                });
            });

            services.AddCors(options =>
            {
                options.AddPolicy("AllowJwt",
                    builder =>
                    {
                        // white list
                        builder.WithOrigins("http://localhost:4200");
                        // we have only 3 methods in app, add its.
                        builder.WithMethods("GET", "POST", "OPTIONS");
                        // in request head
                        builder.AllowAnyHeader();
                        // lifetime
                        builder.SetPreflightMaxAge(TimeSpan.FromSeconds(2520));
                    });
            });

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
            app.UseCors("AllowJwt");
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            app.UseCors();
            app.UseOpenApi();
            app.UseSwaggerUi3();

            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("./swagger/v1/swagger.json", "JWT Auth Demo V1");
                c.DocumentTitle = "JWT Auth Demo";
                c.RoutePrefix = string.Empty;
            });

        }
    }
}
