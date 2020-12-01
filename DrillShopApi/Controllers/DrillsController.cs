using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DrillShopApi.Common.Swagger;
using DrillShopApi.Services.Interfaces;
using DrillShopApi.Models.DTO;
using DrillShopApi.Models.Responses;
using DrillShopApi.Models.Requests.Drill;
using AutoMapper;
using System.Threading.Tasks;
using System.Threading;


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
        private readonly IMapper _mapper;

        /// <summary>
        /// Инициализирует экземпляр <see cref="DrillsController"/>.
        /// </summary>
        /// <param name="drillService">Сервис сверл.</param>
        /// <param name="logger">Логгер.</param>
        /// <param name="mapper">Маппер.</param>
        public DrillsController(IDrillService drillService, ILogger<DrillsController> logger, IMapper mapper)
        {
            _drillService = drillService;
            _logger = logger;
            _mapper = mapper;
        }

        /// <summary>
        /// Получение перечня доступных в магазине сверл.
        /// </summary>
        /// <returns>Коллекция сущностей "Сверло".</returns>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<DrillResponse>))]
        public async Task<IActionResult> GetAsync(CancellationToken cancellationToken)
        {
            _logger.LogInformation("Drills/Get was requested.");
            var response = await _drillService.GetAsync(cancellationToken);
            return Ok(_mapper.Map<IEnumerable<DrillResponse>>(response));
        }

        /// <summary>
        /// Получение сверла по Id.
        /// </summary>
        /// <returns>Cущность "Сверло".</returns>
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(DrillResponse))]
        public async Task<IActionResult> GetByIdAsync(long id, CancellationToken cancellationToken)
        {
            _logger.LogInformation("Drills/GetById was requested.");
            var response = await _drillService.GetAsync(id, cancellationToken);
            return Ok(_mapper.Map<DrillResponse>(response));
        }

        /// <summary>
        /// Добавление сущности "Сверло".
        /// </summary>
        /// <returns>Cущность "Сверло".</returns>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(DrillResponse))]
        public async Task<IActionResult> PostAsync(CreateDrillRequest request, CancellationToken cancellationToken)
        {
            _logger.LogInformation("Drills/Post was requested.");
            var response = await _drillService.CreateAsync(_mapper.Map<DrillDto>(request));
            return Ok(_mapper.Map<DrillResponse>(response));
        }

        /// <summary>
        /// Изменение сущности "Сверло".
        /// </summary>
        /// <returns>Cущность "Сверло".</returns>
        [HttpPut]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(DrillResponse))]
        public async Task<IActionResult> PutAsync(UpdateDrillRequest request, CancellationToken cancellationToken)
        {
            _logger.LogInformation("Drills/Put was requested.");
            var response = await _drillService.UpdateAsync(_mapper.Map<DrillDto>(request));
            return Ok(_mapper.Map<DrillResponse>(response));
        }

        /// <summary>
        /// Удаление сущностей "Сверло".
        /// </summary>
        [HttpDelete]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public async Task<IActionResult> DeleteAsync(CancellationToken cancellationToken, params long[] ids)
        {
            _logger.LogInformation("Drills/Delete was requested.");
            await _drillService.DeleteAsync(ids);
            return NoContent();
        }
    }
}

