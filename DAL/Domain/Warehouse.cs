using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DrillShopApi.DAL.Domain
{
    /// <summary>
    /// Склад.
    /// </summary>
    public class Warehouse : BaseDimEntity
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
