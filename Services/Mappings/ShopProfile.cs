using DrillShopApi.DAL.Domain;
using DrillShopApi.Models.DTO;
using AutoMapper;

namespace Services.Mappings
{
    /// <summary>
    /// Профиль маппинга (магазин).
    /// </summary>
    public class ShopProfile : Profile
    {
        /// <summary>
        /// Инициализирует экземпляр <see cref="ShopProfile"/>.
        /// </summary>
        public ShopProfile()
        {
            CreateMap<Shop, ShopDto>();
        }
    }
}
