using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DrillShopApi.Common.Swagger;
using DrillShopApi.Services.Interfaces;
using DrillShopApi.Models.DTO;
using DrillShopApi.Models.Responses;
using DrillShopApi.Models.Requests.Provider;
using AutoMapper;
using System.Threading.Tasks;
using System.Threading;

namespace DrillShopApi.Controllers
{
    /// <summary>
    /// Контроллер для работы с данными о поставщике.
    /// </summary>
    [ApiController]
    [Route("[controller]")]
    [ApiExplorerSettings(GroupName = SwaggerDocParts.Providers)]
    public class ProvidersController : ControllerBase
    {
        private readonly ILogger<ProvidersController> _logger;
        private readonly IProviderService _providerService;
        private readonly IMapper _mapper;

        /// <summary>
        /// Инициализирует экземпляр <see cref="ProvidersController"/>
        /// </summary>
        /// <param name="providerService">Сервис поставщиков.</param>
        /// <param name="logger">Логгер.</param>
        /// <param name="mapper">Маппер.</param>
        public ProvidersController(IProviderService providerService, ILogger<ProvidersController> logger, IMapper mapper)
        {
            _providerService = providerService;
            _logger = logger;
            _mapper = mapper;
        }

        /// <summary>
        /// Получение перечня поставщиков.
        /// </summary>
        /// <returns>Коллекция сущностей "Поставщик".</returns>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<ProviderResponse>))]
        public async Task<IActionResult> GetAsync(CancellationToken cancellationToken)
        {
            _logger.LogInformation("Providers/Get was requested.");
            var response = await _providerService.GetAsync(cancellationToken);
            return Ok(_mapper.Map<IEnumerable<ProviderResponse>>(response));
        }

        /// <summary>
        /// Получение поставщиков по Id.
        /// </summary>
        /// <returns>Cущность "Поставщик".</returns>
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ProviderResponse))]
        public async Task<IActionResult> GetByIdAsync(long id, CancellationToken cancellationToken)
        {
            _logger.LogInformation("Providers/GetById was requested.");
            var response = await _providerService.GetAsync(id, cancellationToken);
            return Ok(_mapper.Map<ProviderResponse>(response));
        }

        /// <summary>
        /// Добавление сущности "Поставщик".
        /// </summary>
        /// <returns>Cущность "Поставщик".</returns>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ProviderResponse))]
        public async Task<IActionResult> PostAsync(CreateProviderRequest request, CancellationToken cancellationToken)
        {
            _logger.LogInformation("Providers/Post was requested.");
            var response = await _providerService.CreateAsync(_mapper.Map<ProviderDto>(request));
            return Ok(_mapper.Map<ProviderResponse>(response));
        }

        /// <summary>
        /// Изменение сущности "Поставщик".
        /// </summary>
        /// <returns>Cущность "Поставщик".</returns>
        [HttpPut]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ProviderResponse))]
        public async Task<IActionResult> PutAsync(UpdateProviderRequest request, CancellationToken cancellationToken)
        {
            _logger.LogInformation("Dresses/Put was requested.");
            var response = await _providerService.UpdateAsync(_mapper.Map<ProviderDto>(request));
            return Ok(_mapper.Map<ProviderResponse>(response));
        }

        /// <summary>
        /// Удаление сущностей "Поставщик".
        /// </summary>
        [HttpDelete]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public async Task<IActionResult> DeleteAsync(CancellationToken cancellationToken, params long[] ids)
        {
            _logger.LogInformation("Providers/Delete was requested.");
            await _providerService.DeleteAsync(ids);
            return NoContent();
        }
    }
}