using DrillShopApi.DAL.Contexts;
using DrillShopApi.DAL.Domain;
using DrillShopApi.Models.DTO;
using DrillShopApi.Repositories.Interfaces;
using AutoMapper;

namespace DrillShopApi.Repositories
{
    /// <summary>
    /// Репозиторий для работы с сущностями "Склад".
    /// </summary>
    public class WarehouseRepository : BaseRepository<WarehouseDto, Warehouse>, IWarehouseRepository
    {
        /// <summary>
        /// Инициализирует экземпляр <see cref="WarehouseRepository"/>.
        /// </summary>
        /// <param name="context">Контекст данных.</param>
        /// <param name="mapper">Маппер.</param>
        public WarehouseRepository(DrillShopContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}
