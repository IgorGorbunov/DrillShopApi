using DrillShopApi.DAL.Domain;
using System.ComponentModel.DataAnnotations;

namespace DrillShopApi.Models.DTO
{
    /// <summary>
    /// DTO для <see cref="Drill"/>.
    /// </summary>
    public class DrillDto : BaseDto
    {
        /// <summary>
        /// Артикул.
        /// </summary>
        [Required]
        public string ArtCode { get; set; }

        /// <summary>
        /// Описание.
        /// </summary>
        [MaxLength(2000)]
        public string Description { get; set; }

        /// <summary>
        /// Вес.
        /// </summary>
        [Required]
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
        public Provider Provider { get; set; }

        /// <summary>
        /// Идентификатор поставщика.
        /// </summary>
        public long ProviderId { get; set; }

        /// <summary>
        /// Тип сверла.
        /// </summary>
        public string DrillType { get; set; }

    }
}
