using DrillShopApi.DAL.Domain;
using DrillShopApi.Models.DTO;
using AutoMapper;

namespace Services.Mappings
{
    /// <summary>
    /// Профиль маппинга (доступность в магазине).
    /// </summary>
    public class ShopAvailabilityProfile : Profile
    {
        /// <summary>
        /// Инициализирует экземпляр <see cref="ShopAvailabilityProfile"/>.
        /// </summary>
        public ShopAvailabilityProfile()
        {
            CreateMap<ShopAvailability, ShopAvailabilityDto>().ReverseMap();
        }
    }
}
