using System.ComponentModel.DataAnnotations;

namespace DrillShopApi.Models.Requests.Shop
{
    /// <summary>
    /// Запрос на изменение позиции магазина.
    /// </summary>
    public class UpdateShopRequest : CreateShopRequest
    {
        /// <summary>
        /// Идентификатор сущности.
        /// </summary>
        [Required]
        public long Id { get; set; }
    }
}
