using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DrillShopApi.Common.Swagger;
using DrillShopApi.Services.Interfaces;
using DrillShopApi.Models.DTO;


namespace DrillShopApi.Controllers
{
    /// <summary>
    /// Контроллер для работы с данными о сверлах.
    /// </summary>
    [ApiController]
    [Route("[controller]")]
    [ApiExplorerSettings(GroupName = SwaggerDocParts.Drills)]
    public class DrillsController : ControllerBase 
    {
        private readonly ILogger<DrillsController> _logger;
        private readonly IDrillService _drillService;

        /// <summary>
        /// Инициализирует экземпляр <see cref="DrillsController"/>.
        /// </summary>
        /// <param name="drillService">Сервис сверл.</param>
        /// <param name="logger">Логгер.</param>
        public DrillsController(IDrillService drillService, ILogger<DrillsController> logger)
        {
            _drillService = drillService;
            _logger = logger;
        }

        /// <summary>
        /// Получение перечня доступных в магазине сверл.
        /// </summary>
        /// <returns>Коллекция сущностей "Сверло".</returns>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<DrillDto>))]
        public IActionResult Get()
        {
            _logger.LogInformation("Drills/Get was requested.");
            var response = _drillService.GetAsync();
            return Ok(response);
        }
    }
}
