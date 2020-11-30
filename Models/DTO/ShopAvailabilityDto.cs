using DrillShopApi.DAL.Domain;
using System.ComponentModel.DataAnnotations;

namespace DrillShopApi.Models.DTO
{
    /// <summary>
    /// DTO для <see cref="ShopAvailability"/>.
    /// </summary>
    public class ShopAvailabilityDto : BaseDto
    {
        /// <summary>
        /// Количество доступных единиц.
        /// </summary>
        [Required]
        public int Count { get; set; }

        /// <summary>
        /// Магазин.
        /// </summary>
        [Required]
        public Shop Shop { get; set; }

        /// <summary>
        /// Сверло.
        /// </summary>
        [Required]
        public Drill Drill { get; set; }
    }
}
