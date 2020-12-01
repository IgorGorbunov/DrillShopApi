using DrillShopApi.Models.Responses;
using DrillShopApi.Models.Requests.Warehouse;
using DrillShopApi.Models.DTO;
using AutoMapper;

namespace Services.Mappings
{
    /// <summary>
    /// Маппинг для запросов и ответов контроллера сущности склад.
    /// </summary>
    public class WarehouseProfile : Profile
    {
        /// <summary>
        /// Инициализирует экземпляр <see cref="WarehouseProfile"/>.
        /// </summary>
        public WarehouseProfile()
        {
            CreateMap<CreateWarehouseRequest, WarehouseDto>();
            CreateMap<UpdateWarehouseRequest, WarehouseDto>();
            CreateMap<WarehouseDto, WarehouseResponse>();
        }
    }
}
