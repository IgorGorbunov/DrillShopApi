using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DrillShopApi.DAL.Domain
{
    /// <summary>
    /// Наличие инструмента в магазине.
    /// </summary>
    public class ShopAvailability : BaseEntity
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
