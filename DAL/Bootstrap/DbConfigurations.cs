using System.Reflection;
using DrillShopApi.DAL.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DrillShopApi.DAL.Bootstrap
{
    /// <summary>
    /// Конфигурации БД.
    /// </summary>
    public static class DbConfigurations
    {
        /// <summary>
        /// Подключение DbContext.
        /// </summary>
        /// <param name="services">Коллекция сервисов.</param>
        /// <param name="configuration">Конфигурация.</param>
        public static void ConfigureDb(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<DrillShopContext>(
                options =>
                {
                    options.UseNpgsql(
                                        configuration.GetConnectionString(nameof(DrillShopContext)),
                                        builder =>
                                        {
                                            builder.MigrationsAssembly(typeof(DrillShopContext).Assembly.FullName);
                                        });
                });
        }
    }
}