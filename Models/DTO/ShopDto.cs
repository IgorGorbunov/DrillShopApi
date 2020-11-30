using System;
using System.Collections.Generic;
using System.Text;
using DrillShopApi.DAL.Domain;
using System.ComponentModel.DataAnnotations;

namespace DrillShopApi.Models.DTO
{
    /// <summary>
    /// DTO для <see cref="Shop"/>.
    /// </summary>
    public class ShopDto
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
        /// Телефон.
        /// </summary>
        [StringLength(50)]
        [Required]
        public string Telephone { get; set; }
    }
}
