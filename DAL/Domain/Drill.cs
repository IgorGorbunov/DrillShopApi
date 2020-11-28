using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DrillShopApi.DAL.Domain
{
    /// <summary>
    /// Сверло.
    /// </summary>
    public class Drill : BaseStructEntity
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
    }
}
