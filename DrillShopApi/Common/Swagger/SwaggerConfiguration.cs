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
                c.Title = "Version 2";
                c.DocumentName = "v2";
                c.ApiGroupNames = new[] { "v2" };
            });
        }
    }
}
