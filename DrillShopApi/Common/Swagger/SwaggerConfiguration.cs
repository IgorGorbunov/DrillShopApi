using Microsoft.Extensions.DependencyInjection;

namespace DrillShopApi.Common.Swagger
{
    /// <summary>
    /// Расширения для конфигурации Swagger.
    /// </summary>
    public static class SwaggerConfiguration
    {
        /// <summary>
        /// Настройка документов Swagger.
        /// </summary>
        /// <param name="services">Коллекция сервисов для DI.</param>
        public static void ConfigureSwagger(this IServiceCollection services)
        {
            services.AddSwaggerDocument(c =>
            {
                c.Title = "Drills";
                c.DocumentName = SwaggerDocParts.Drills;
                c.ApiGroupNames = new[] { SwaggerDocParts.Drills };
                c.GenerateXmlObjects = true;
            })
            .AddSwaggerDocument(c =>
            {
                c.Title = "Providers";
                c.DocumentName = SwaggerDocParts.Providers;
                c.ApiGroupNames = new[] { SwaggerDocParts.Providers };
                c.GenerateXmlObjects = true;
            })
            .AddSwaggerDocument(c =>
            {
                c.Title = "Shops";
                c.DocumentName = SwaggerDocParts.Shops;
                c.ApiGroupNames = new[] { SwaggerDocParts.Shops };
                c.GenerateXmlObjects = true;
            })
            .AddSwaggerDocument(c =>
            {
                c.Title = "Warehouses";
                c.DocumentName = SwaggerDocParts.Warehouses;
                c.ApiGroupNames = new[] { SwaggerDocParts.Warehouses };
                c.GenerateXmlObjects = true;
            });
        }
    }
}
