using Microsoft.Extensions.DependencyInjection;
using DrillShopApi.Repositories.Interfaces;

namespace DrillShopApi.Repositories.Bootstrap
{
    /// <summary>
    /// Расширения для конфигурации репозиториев.
    /// </summary>
    public static class RepositoriesConfiguration
    {
        public static void ConfigureRepositories (this IServiceCollection services)
        {
            services.AddTransient<IDrillRepository, DrillRepository>();
            services.AddTransient<IShopRepository, ShopRepository>();
            services.AddTransient<IProviderRepository, ProviderRepository>();
            services.AddTransient<IWarehouseRepository, WarehouseRepository>();
            services.AddTransient<IUnitOfWork, UnitOfWork>();
        }
    }
}
