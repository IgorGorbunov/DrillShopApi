using DrillShopApi.DAL.Domain;
using System.ComponentModel.DataAnnotations;

namespace DrillShopApi.Models.DTO
{
    /// <summary>
    /// DTO для <see cref="WHAvailability"/>.
    /// </summary>
    public class WHAvailabilityDto : BaseDto
    {
        /// <summary>
        /// Количество доступных единиц.
        /// </summary>
        [Required]
        public int Count { get; set; }

        /// <summary>
        /// Склад.
        /// </summary>
        [Required]
        public WarehouseDto Warehouse { get; set; }

        /// <summary>
        /// Сверло.
        /// </summary>
        [Required]
        public DrillDto Drill { get; set; }
    }
}
