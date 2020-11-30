using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace DrillShopApi.Services.Interfaces
{
    /// <summary>
    /// Интерфейс сервиса для получения сущностей.
    /// </summary>
    /// <typeparam name="TDto">DTO.</typeparam>
    public interface IGettable<TDto>
    {
        /// <summary>
        /// Получение сущностей.
        /// </summary>
        /// <param name="token">Экземпляр <see cref="CancellationToken"/>.</param>
        /// <returns>Сущности.</returns>
        Task<IEnumerable<TDto>> GetAsync(CancellationToken token = default);
    }
}