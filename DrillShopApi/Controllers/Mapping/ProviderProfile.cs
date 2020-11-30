using DrillShopApi.Models.Responses;
using DrillShopApi.Models.Requests.Provider;
using DrillShopApi.Models.DTO;
using AutoMapper;

namespace Services.Mappings
{
    /// <summary>
    /// Маппинг для запросов и ответов контроллера сущности Поставщик.
    /// </summary>
    public class ProviderProfile :Profile
    {
        /// <summary>
        /// Инициализирует экземпляр <see cref="ProviderProfile"/>.
        /// </summary>
        public ProviderProfile()
        {
            CreateMap<CreateProviderRequest, ProviderDto>();
            CreateMap<UpdateProviderRequest, ProviderDto>();
            CreateMap<ProviderDto, ProviderResponse>();
        }
    }
}
