using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.DependencyInjection;
using DrillShopApi.Services.Interfaces;
using DrillShopApi.Services.Services;

namespace DrillShopApi.Services.Bootstrap
{
    /// <summary>
    /// Методы расширения для конфигурации сервисов.
    /// </summary>
    public static class ServicesConfiguration
    {
        /// <summary>
        /// Конфигурация сервисов.
        /// </summary>
        /// <param name="services">Коллекция сервисов из Startup.</param>
        public static void ConfigureServices(this IServiceCollection services)
        {
            services.AddTransient<IDrillService, DrillService>();
        }
    }
}
