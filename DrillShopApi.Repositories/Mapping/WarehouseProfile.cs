using DrillShopApi.DAL.Domain;
using DrillShopApi.Models.DTO;
using AutoMapper;

namespace Services.Mappings
{
    /// <summary>
    /// Профиль маппинга (склад).
    /// </summary>
    public class WarehouseProfile : Profile
    {
        /// <summary>
        /// Инициализирует экземпляр <see cref="WarehouseProfile"/>.
        /// </summary>
        public WarehouseProfile()
        {
            CreateMap<Warehouse, WarehouseDto>().ReverseMap();
        }
    }
}
