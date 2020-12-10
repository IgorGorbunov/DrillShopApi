using DrillShopApi.Models.Responses;
using DrillShopApi.Models.Requests.Drill;
using DrillShopApi.Models.DTO;
using AutoMapper;

namespace Services.Mappings
{
    /// <summary>
    /// Маппинг для запросов и ответов контроллера сущности сверла.
    /// </summary>
    public class DrillPofile : Profile
    {
        /// <summary>
        /// Инициализирует экземпляр <see cref="DrillPofile"/>.
        /// </summary>
        public DrillPofile()
        {
            CreateMap<CreateDrillRequest, DrillDto>();
            CreateMap<UpdateDrillRequest, DrillDto>();
            CreateMap<DrillDto, DrillResponse>()
                .ForMember(x => x.ProviderName, y => y.MapFrom(src => src.Provider.Name))
                .ForMember(x => x.ProviderCity, y => y.MapFrom(src => src.Provider.City))
                .ForMember(x => x.ProviderAddress, y => y.MapFrom(src => src.Provider.Address));
        }
    }
}
