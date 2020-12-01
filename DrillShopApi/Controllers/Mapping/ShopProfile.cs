using DrillShopApi.Models.Responses;
using DrillShopApi.Models.Requests.Shop;
using DrillShopApi.Models.DTO;
using AutoMapper;

namespace Services.Mappings
{
    /// <summary>
    /// Маппинг для запросов и ответов контроллера сущности магазин.
    /// </summary>
    public class ShopProfile : Profile
    {
        /// <summary>
        /// Инициализирует экземпляр <see cref="ShopProfile"/>.
        /// </summary>
        public ShopProfile()
        {
            CreateMap<CreateShopRequest, ShopDto>();
            CreateMap<UpdateShopRequest, ShopDto>();
            CreateMap<ShopDto, ShopResponse>();
        }
    }
}
