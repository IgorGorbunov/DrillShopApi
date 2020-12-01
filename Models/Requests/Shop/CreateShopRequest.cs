using System.ComponentModel.DataAnnotations;

namespace DrillShopApi.Models.Requests.Shop
{
    /// <summary>
    /// Запрос на создание позиции магазина.
    /// </summary>
    public class CreateShopRequest
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
