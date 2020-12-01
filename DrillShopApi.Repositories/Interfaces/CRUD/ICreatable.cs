using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DrillShopApi.Repositories.Interfaces.CRUD
{
    /// <summary>
    /// Интерфейс для создания сущностей.
    /// </summary>
    /// <typeparam name="TDto">DTO.</typeparam>
    /// <typeparam name="TModel">Domain model.</typeparam>
    public interface ICreatable<TDto, TModel>
    {
        /// <summary>
        /// Создание сущности.
        /// </summary>
        /// <param name="dto">DTO.</param>
        /// <returns>Идентификатор созданной сущности.</returns>
        Task<TDto> CreateAsync(TDto dto);
    }
}
