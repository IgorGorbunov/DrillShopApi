using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DrillShopApi.DAL.Domain
{
    /// <summary>
    /// Сверло.
    /// </summary>
    public class Drill : BaseDimEntity
    {
        /// <summary>
        /// Артикул.
        /// </summary>
        [StringLength(50)]
        [Required]
        public string ArtCode { get; set; }

        /// <summary>
        /// Описание.
        /// </summary>
        [StringLength(200)]
        public string Description { get; set; }

        /// <summary>
        /// Вес.
        /// </summary>
        public double Weight { get; set; }

        /// <summary>
        /// Минимальный диаметр.
        /// </summary>
        [Required]
        public double MinDiametr { get; set; }

        /// <summary>
        /// Максимальный диаметр.
        /// </summary>
        [Required]
        public double MaxDiametr { get; set; }

        /// <summary>
        /// Поставщик.
        /// </summary>
        [Required]
        public Provider Provider { get; set; }

        /// <summary>
        /// Идентификатор поставщика.
        /// </summary>
        public long ProviderId { get; set; }

        /// <summary>
        /// Тип сверла.
        /// </summary>
        public string DrillType { get; set; }

        /// <summary>
        /// Наличие данного сверла в магазинах.
        /// </summary>
        public ICollection<ShopAvailability> ShopAvailabilities { get; set; }

        /// <summary>
        /// Наличие данного сверла на складах.
        /// </summary>
        public ICollection<WHAvailability> WHAvailabilities { get; set; }
    }
}
