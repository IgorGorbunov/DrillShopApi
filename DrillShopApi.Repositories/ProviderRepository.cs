using DrillShopApi.DAL.Contexts;
using DrillShopApi.DAL.Domain;
using DrillShopApi.Models.DTO;
using DrillShopApi.Repositories.Interfaces;
using AutoMapper;

namespace DrillShopApi.Repositories
{
    /// <summary>
    /// Репозиторий для работы с сущностями "Поставщик".
    /// </summary>
    public class ProviderRepository : BaseRepository<ProviderDto, Provider>, IProviderRepository
    {
        /// <summary>
        /// Инициализирует экземпляр <see cref="ProviderRepository"/>.
        /// </summary>
        /// <param name="context">Контекст данных.</param>
        /// <param name="mapper">Маппер.</param>
        public ProviderRepository(DrillShopContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}
