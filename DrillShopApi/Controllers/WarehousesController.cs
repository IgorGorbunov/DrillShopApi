using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DrillShopApi.Common.Swagger;
using DrillShopApi.Services.Interfaces;
using DrillShopApi.Models.DTO;
using DrillShopApi.Models.Responses;
using DrillShopApi.Models.Requests.Warehouse;
using AutoMapper;
using System.Threading.Tasks;
using System.Threading;


namespace DrillShopApi.Controllers
{
    /// <summary>
    /// Контроллер для работы с данными о складах.
    /// </summary>
    [ApiController]
    [Route("[controller]")]
    [ApiExplorerSettings(GroupName = SwaggerDocParts.Warehouses)]
    public class WarehousesController : ControllerBase
    {
        private readonly ILogger<WarehousesController> _logger;
        private readonly IWarehouseService _warehouseService;
        private readonly IMapper _mapper;

        /// <summary>
        /// Инициализирует экземпляр <see cref="WarehousesController"/>
        /// </summary>
        /// <param name="warehouseService">Сервис складов.</param>
        /// <param name="logger">Логгер.</param>
        /// <param name="mapper">Маппер.</param>
        public WarehousesController(IWarehouseService warehouseService, ILogger<WarehousesController> logger, IMapper mapper)
        {
            _warehouseService = warehouseService;
            _logger = logger;
            _mapper = mapper;
        }

        /// <summary>
        /// Получение перечня доступных складов.
        /// </summary>
        /// <returns>Коллекция сущностей "Склад".</returns>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<WarehouseResponse>))]
        public async Task<IActionResult> GetAsync(CancellationToken cancellationToken)
        {
            _logger.LogInformation("Warehouses/Get was requested.");
            var response = await _warehouseService.GetAsync(cancellationToken);
            return Ok(_mapper.Map<IEnumerable<WarehouseResponse>>(response));
        }

        /// <summary>
        /// Получение складов по Id.
        /// </summary>
        /// <returns>Cущность "Склад".</returns>
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(WarehouseResponse))]
        public async Task<IActionResult> GetByIdAsync(long id, CancellationToken cancellationToken)
        {
            _logger.LogInformation("Warehouses/GetById was requested.");
            var response = await _warehouseService.GetAsync(id, cancellationToken);
            return Ok(_mapper.Map<WarehouseResponse>(response));
        }

        /// <summary>
        /// Добавление сущности "Склад".
        /// </summary>
        /// <returns>Cущность "Склад".</returns>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(WarehouseResponse))]
        public async Task<IActionResult> PostAsync(CreateWarehouseRequest request, CancellationToken cancellationToken)
        {
            _logger.LogInformation("Warehouses/Post was requested.");
            var response = await _warehouseService.CreateAsync(_mapper.Map<WarehouseDto>(request));
            return Ok(_mapper.Map<WarehouseResponse>(response));
        }

        /// <summary>
        /// Изменение сущности "Склад".
        /// </summary>
        /// <returns>Cущность "Склад".</returns>
        [HttpPut]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(WarehouseResponse))]
        public async Task<IActionResult> PutAsync(UpdateWarehouseRequest request, CancellationToken cancellationToken)
        {
            _logger.LogInformation("Warehouses/Put was requested.");
            var response = await _warehouseService.UpdateAsync(_mapper.Map<WarehouseDto>(request));
            return Ok(_mapper.Map<WarehouseResponse>(response));
        }

        /// <summary>
        /// Удаление сущностей "Склад".
        /// </summary>
        [HttpDelete]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public async Task<IActionResult> DeleteAsync(CancellationToken cancellationToken, params long[] ids)
        {
            _logger.LogInformation("Warehouses/Delete was requested.");
            await _warehouseService.DeleteAsync(ids);
            return NoContent();
        }
    }
}