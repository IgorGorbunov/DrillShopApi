﻿using System.ComponentModel.DataAnnotations;

namespace DrillShopApi.Models.Requests.Warehouse
{
    /// <summary>
    /// Запрос на создание позиции склада.
    /// </summary>
    public class CreateWarehouseRequest
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
