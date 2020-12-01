using System.Collections.Generic;
using DrillShopApi.Models.DTO;
using DrillShopApi.Services.Interfaces;
using DrillShopApi.Repositories.Interfaces;
using System.Threading.Tasks;
using System.Threading;

namespace DrillShopApi.Services.Services
{
    /// <summary>
    /// Сервис для работы с данными о сверлах.
    /// </summary>
    public class DrillService : IDrillService
    {
        private readonly IDrillRepository _repository;

        /// <summary>
        /// Инициализирует экземпляр <see cref="DrillService"/>.
        /// </summary>
        /// <param name="repository">Репозиторий.</param>
        public DrillService(IDrillRepository repository)
        {
            _repository = repository;
        }

        ///<inheritdoc cref="ICreatable{TDto}.CreateAsync(TDto)"/>
        public async Task<DrillDto> CreateAsync(DrillDto dto)
        {
            return await _repository.CreateAsync(dto);
        }

        /// <inheritdoc cref="IDeletable.DeleteAsync(long[])"/>
        public async Task DeleteAsync(params long[] ids)
        {
            await _repository.DeleteAsync(ids);
        }

        /// <inheritdoc cref="IGettableById{TDto}.GetAsync(long, CancellationToken)"/>
        public async Task<DrillDto> GetAsync(long id, CancellationToken token = default)
        {
            return await _repository.GetAsync(id);
        }

        /// <inheritdoc cref="IGettable{TDto}.GetAsync(CancellationToken)"/>
        public async Task<IEnumerable<DrillDto>> GetAsync(CancellationToken token = default)
        {
            return await _repository.GetAsync();
        }

        /// <inheritdoc cref="IUpdatable{TDto}.UpdateAsync(TDto)"/>
        public async Task<DrillDto> UpdateAsync(DrillDto dto)
        {
            return await _repository.UpdateAsync(dto);
        }

    }
}
