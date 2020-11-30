using DrillShopApi.DAL.Domain;
using System.ComponentModel.DataAnnotations;

namespace DrillShopApi.Models.DTO
{
    /// <summary>
    /// DTO для <see cref="Warehouse"/>.
    /// </summary>
    public class WarehouseDto : BaseDto
    {
        /// <summary>
        /// Наименование.
        /// </summary>
        [StringLength(50)]
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// Город.
        /// </summary>
        [StringLength(50)]
        [Required]
        public string City { get; set; }

        /// <summary>
        /// Адрес.
        /// </summary>
        [StringLength(50)]
        [Required]
        public string Address { get; set; }

        /// <summary>
        /// Площадь помещения.
        /// </summary>
        [Required]
        public double Area { get; set; }

        /// <summary>
        /// Вместимость помещения.
        /// </summary>
        public double Capacity { get; set; }
    }
}
