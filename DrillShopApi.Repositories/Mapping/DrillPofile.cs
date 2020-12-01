using DrillShopApi.DAL.Domain;
using DrillShopApi.Models.DTO;
using AutoMapper;

namespace Services.Mappings
{
    /// <summary>
    /// Профиль маппинга (сверла).
    /// </summary>
    public class DrillPofile : Profile
    {
        /// <summary>
        /// Инициализирует экземпляр <see cref="DrillPofile"/>.
        /// </summary>
        public DrillPofile()
        {
            CreateMap<Drill, DrillDto>().ReverseMap();
        }
    }
}
