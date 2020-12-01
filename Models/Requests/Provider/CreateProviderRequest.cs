using System.ComponentModel.DataAnnotations;

namespace DrillShopApi.Models.Requests.Provider
{
    /// <summary>
    /// Запрос на создание позиции поставщика.
    /// </summary>
    public class CreateProviderRequest
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
    }
}
