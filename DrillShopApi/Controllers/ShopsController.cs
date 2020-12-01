using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DrillShopApi.Common.Swagger;
using DrillShopApi.Services.Interfaces;
using DrillShopApi.Models.DTO;
using DrillShopApi.Models.Responses;
using DrillShopApi.Models.Requests.Shop;
using AutoMapper;
using System.Threading.Tasks;
using System.Threading;

namespace DrillShopApi.Controllers
{
    /// <summary>
    /// Контроллер для работы с данными о магазинах.
    /// </summary>
    [ApiController]
    [Route("[controller]")]
    [ApiExplorerSettings(GroupName = SwaggerDocParts.Shops)]
    public class ShopsController : ControllerBase
    {
        private readonly ILogger<ShopsController> _logger;
        private readonly IShopService _shopService;
        private readonly IMapper _mapper;

        /// <summary>
        /// Инициализирует экземпляр <see cref="ShopsController"/>
        /// </summary>
        /// <param name="shopService">Сервис магазинов.</param>
        /// <param name="logger">Логгер.</param>
        /// <param name="mapper">Маппер.</param>
        public ShopsController(IShopService shopService, ILogger<ShopsController> logger, IMapper mapper)
        {
            _shopService = shopService;
            _logger = logger;
            _mapper = mapper;
        }

        /// <summary>
        /// Получение перечня доступных магазинов.
        /// </summary>
        /// <returns>Коллекция сущностей "Магазин".</returns>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<ShopResponse>))]
        public async Task<IActionResult> GetAsync(CancellationToken cancellationToken)
        {
            _logger.LogInformation("Shops/Get was requested.");
            var response = await _shopService.GetAsync(cancellationToken);
            return Ok(_mapper.Map<IEnumerable<ShopResponse>>(response));
        }

        /// <summary>
        /// Получение магазина по Id.
        /// </summary>
        /// <returns>Cущность "Магазин".</returns>
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ShopResponse))]
        public async Task<IActionResult> GetByIdAsync(long id, CancellationToken cancellationToken)
        {
            _logger.LogInformation("Shops/GetById was requested.");
            var response = await _shopService.GetAsync(id, cancellationToken);
            return Ok(_mapper.Map<ShopResponse>(response));
        }

        /// <summary>
        /// Добавление сущности "Магазин".
        /// </summary>
        /// <returns>Cущность "Магазин".</returns>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ShopResponse))]
        public async Task<IActionResult> PostAsync(CreateShopRequest request, CancellationToken cancellationToken)
        {
            _logger.LogInformation("Shops/Post was requested.");
            var response = await _shopService.CreateAsync(_mapper.Map<ShopDto>(request));
            return Ok(_mapper.Map<ShopResponse>(response));
        }

        /// <summary>
        /// Изменение сущности "Магазин".
        /// </summary>
        /// <returns>Cущность "Магазин".</returns>
        [HttpPut]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ShopResponse))]
        public async Task<IActionResult> PutAsync(UpdateShopRequest request, CancellationToken cancellationToken)
        {
            _logger.LogInformation("Shops/Put was requested.");
            var response = await _shopService.UpdateAsync(_mapper.Map<ShopDto>(request));
            return Ok(_mapper.Map<ShopResponse>(response));
        }

        /// <summary>
        /// Удаление сущностей "Магазин".
        /// </summary>
        [HttpDelete]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public async Task<IActionResult> DeleteAsync(CancellationToken cancellationToken, params long[] ids)
        {
            _logger.LogInformation("Shops/Delete was requested.");
            await _shopService.DeleteAsync(ids);
            return NoContent();
        }
    }
}