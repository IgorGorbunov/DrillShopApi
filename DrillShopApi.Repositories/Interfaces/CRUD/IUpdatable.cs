using System.Threading.Tasks;
using System.Threading;

namespace DrillShopApi.Repositories.Interfaces.CRUD
{
    /// <summary>
    /// Интерфейс для изменения сущностей.
    /// </summary>
    public interface IUpdatable<TDto, TModel>
    {
        /// <summary>
        /// Изменение сущности.
        /// </summary>
        /// <param name="dto">DTO.</param>
        /// <param name="token">Экземпляр <see cref="CancellationToken"/>.</param>
        /// <returns>Обновленная сущность.</returns>
        Task<TDto> UpdateAsync(TDto dto, CancellationToken token = default);
    }
}
