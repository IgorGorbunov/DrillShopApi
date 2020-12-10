using System.Collections.Generic;
using DrillShopApi.Models.DTO;
using DrillShopApi.Services.Interfaces;
using DrillShopApi.Repositories.Interfaces;
using System.Threading.Tasks;
using System.Threading;
using DrillShopApi.Repositories;

namespace DrillShopApi.Services.Services
{
    /// <summary>
    /// Сервис для работы с данными о сверлах.
    /// </summary>
    public class DrillService : IDrillService
    {
        private readonly IUnitOfWork _unitOfWork;

        /// <summary>
        /// Инициализирует экземпляр <see cref="DrillService"/>.
        /// </summary>
        /// <param name="unitOfWork">UnitOfWork.</param>
        public DrillService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        ///<inheritdoc cref="ICreatable{TDto}.CreateAsync(TDto)"/>
        public async Task<DrillDto> CreateAsync(DrillDto dto)
        {
            using var scope = await _unitOfWork.DrillRepository.Context.Database.BeginTransactionAsync();
            try
            {
                var drill = await _unitOfWork.DrillRepository.CreateAsync(dto);
                scope.Commit();
                return drill;
            }

            catch (System.Exception e)
            {
                scope.Rollback();
                throw e;
            }
        }

        /// <inheritdoc cref="IDeletable.DeleteAsync(long[])"/>
        public async Task DeleteAsync(params long[] ids)
        {
            using var scope = await _unitOfWork.DrillRepository.Context.Database.BeginTransactionAsync();
            try
            {
                await _unitOfWork.DrillRepository.DeleteAsync(ids);
                scope.Commit();
            }

            catch (System.Exception e)
            {
                scope.Rollback();
                throw e;
            }
        }

        /// <inheritdoc cref="IGettableById{TDto}.GetAsync(long, CancellationToken)"/>
        public async Task<DrillDto> GetAsync(long id, CancellationToken token = default)
        {
            return await _unitOfWork.DrillRepository.GetAsync(id);
        }

        /// <inheritdoc cref="IGettable{TDto}.GetAsync(CancellationToken)"/>
        public async Task<IEnumerable<DrillDto>> GetAsync(CancellationToken token = default)
        {
            return await _unitOfWork.DrillRepository.GetAsync();
        }

        /// <inheritdoc cref="IUpdatable{TDto}.UpdateAsync(TDto)"/>
        public async Task<DrillDto> UpdateAsync(DrillDto dto)
        {
            using var scope = await _unitOfWork.DrillRepository.Context.Database.BeginTransactionAsync();
            try
            {
                var currency = await _unitOfWork.DrillRepository.UpdateAsync(dto);
                scope.Commit();
                return currency;
            }

            catch (System.Exception e)
            {
                scope.Rollback();
                throw e;
            }
        }

    }
}
