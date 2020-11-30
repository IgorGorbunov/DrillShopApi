using System.Collections.Generic;
using DrillShopApi.Models.DTO;
using DrillShopApi.Services.Interfaces;
using DrillShopApi.Repositories.Interfaces;
using System.Threading.Tasks;
using System.Threading;

namespace DrillShopApi.Services.Services
{
    /// <summary>
    /// Сервис для работы с данными о поставщике.
    /// </summary>
    class ProviderService : IProviderService
    {
        private readonly IProviderRepository _repository;

        /// <summary>
        /// Инициализирует экземпляр <see cref="ProviderService"/>.
        /// </summary>
        /// <param name="repository">Репозиторий.</param>
        public ProviderService(IProviderRepository repository)
        {
            _repository = repository;
        }

        ///<inheritdoc cref="ICreatable{TDto}.CreateAsync(TDto)"/>
        public async Task<ProviderDto> CreateAsync(ProviderDto dto)
        {
            return await _repository.CreateAsync(dto);
        }

        /// <inheritdoc cref="IDeletable.DeleteAsync(long[])"/>
        public async Task DeleteAsync(params long[] ids)
        {
            await _repository.DeleteAsync(ids);
        }

        /// <inheritdoc cref="IGettableById{TDto}.GetAsync(long, CancellationToken)"/>
        public async Task<ProviderDto> GetAsync(long id, CancellationToken token = default)
        {
            return await _repository.GetAsync(id);
        }

        /// <inheritdoc cref="IGettable{TDto}.GetAsync(CancellationToken)"/>
        public async Task<IEnumerable<ProviderDto>> GetAsync(CancellationToken token = default)
        {
            return await _repository.GetAsync();
        }

        /// <inheritdoc cref="IUpdatable{TDto}.UpdateAsync(TDto)"/>
        public async Task<ProviderDto> UpdateAsync(ProviderDto dto)
        {
            return await _repository.UpdateAsync(dto);
        }
    }
}
