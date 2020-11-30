using DrillShopApi.DAL.Contexts;
using DrillShopApi.DAL.Domain;
using DrillShopApi.Models.DTO;
using DrillShopApi.Repositories.Interfaces;
using AutoMapper;

namespace DrillShopApi.Repositories
{
    /// <summary>
    /// Репозиторий для работы с сущностями "Магазин".
    /// </summary>
    public class ShopRepository : BaseRepository<ShopDto, Shop>, IShopRepository
    {
        /// <summary>
        /// Инициализирует экземпляр <see cref="ShopRepository"/>.
        /// </summary>
        /// <param name="context">Контекст данных.</param>
        /// <param name="mapper">Маппер.</param>
        public ShopRepository(DrillShopContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}
