using DrillShopApi.DAL.Domain;
using DrillShopApi.Models.DTO;
using AutoMapper;

namespace Services.Mappings
{
    /// <summary>
    /// Профиль маппинга (Поставщик).
    /// </summary>
    public class ProviderProfile :Profile
    {
        /// <summary>
        /// Инициализирует экземпляр <see cref="ProviderProfile"/>.
        /// </summary>
        public ProviderProfile()
        {
            CreateMap<Provider, ProviderDto>().ReverseMap();
        }
    }
}
