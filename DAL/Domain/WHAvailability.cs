using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DrillShopApi.DAL.Domain
{
    /// <summary>
    /// Наличие инструмента на складе.
    /// </summary>
    public class WHAvailability : BaseEntity
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
        public Warehouse Warehouse { get; set; }

        /// <summary>
        /// Сверло.
        /// </summary>
        [Required]
        public Drill Drill { get; set; }
    }
}
