using DrillShopApi.DAL.Domain;
using DrillShopApi.Models.DTO;
using AutoMapper;

namespace Services.Mappings
{
    /// <summary>
    /// Профиль маппинга (доступность на складе).
    /// </summary>
    public class WHAvailabilityProfile : Profile
    {
        /// <summary>
        /// Инициализирует экземпляр <see cref="WHAvailabilityProfile"/>.
        /// </summary>
        public WHAvailabilityProfile()
        {
            CreateMap<WHAvailability, WHAvailabilityDto>().ReverseMap();
        }
    }
}
