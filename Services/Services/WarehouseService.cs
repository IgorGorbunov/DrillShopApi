using System.Collections.Generic;
using DrillShopApi.Models.DTO;
using DrillShopApi.Services.Interfaces;
using DrillShopApi.Repositories.Interfaces;
using System.Threading.Tasks;
using System.Threading;

namespace DrillShopApi.Services.Services
{
    /// <summary>
    /// Сервис для работы с данными о складах.
    /// </summary>
    public class WarehouseService : IWarehouseService
    {
        private readonly IWarehouseRepository _repository;

        /// <summary>
        /// Инициализирует экземпляр <see cref="WarehouseService"/>.
        /// </summary>
        /// <param name="repository">Репозиторий.</param>
        public WarehouseService(IWarehouseRepository repository)
        {
            _repository = repository;
        }

        ///<inheritdoc cref="ICreatable{TDto}.CreateAsync(TDto)"/>
        public async Task<WarehouseDto> CreateAsync(WarehouseDto dto)
        {
            return await _repository.CreateAsync(dto);
        }

        /// <inheritdoc cref="IDeletable.DeleteAsync(long[])"/>
        public async Task DeleteAsync(params long[] ids)
        {
            await _repository.DeleteAsync(ids);
        }

        /// <inheritdoc cref="IGettableById{TDto}.GetAsync(long, CancellationToken)"/>
        public async Task<WarehouseDto> GetAsync(long id, CancellationToken token = default)
        {
            return await _repository.GetAsync(id);
        }

        /// <inheritdoc cref="IGettable{TDto}.GetAsync(CancellationToken)"/>
        public async Task<IEnumerable<WarehouseDto>> GetAsync(CancellationToken token = default)
        {
            return await _repository.GetAsync();
        }

        /// <inheritdoc cref="IUpdatable{TDto}.UpdateAsync(TDto)"/>
        public async Task<WarehouseDto> UpdateAsync(WarehouseDto dto)
        {
            return await _repository.UpdateAsync(dto);
        }
    }
}
