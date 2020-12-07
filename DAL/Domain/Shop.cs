using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace DrillShopApi.DAL.Domain
{
    /// <summary>
    /// Магазин.
    /// </summary>
    public class Shop : BaseDimEntity
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

        /// <summary>
        /// Наличие данного сверла в магазинах.
        /// </summary>
        public ICollection<ShopAvailability> ShopAvailabilities { get; set; }
    }
}
