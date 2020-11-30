using DrillShopApi.DAL.Domain;
using System.ComponentModel.DataAnnotations;

namespace DrillShopApi.Models.DTO
{
    /// <summary>
    /// DTO для <see cref="Provider"/>.
    /// </summary>
    public class ProviderDto
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
