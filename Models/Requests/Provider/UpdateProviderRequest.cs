using System.ComponentModel.DataAnnotations;

namespace DrillShopApi.Models.Requests.Provider
{
    /// <summary>
    /// Запрос на изменение позиции поставщика.
    /// </summary>
    public class UpdateProviderRequest : CreateProviderRequest
    {
        /// <summary>
        /// Идентификатор сущности.
        /// </summary>
        [Required]
        public long Id { get; set; }
    }
}
