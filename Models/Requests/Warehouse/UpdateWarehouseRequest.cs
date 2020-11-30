using System.ComponentModel.DataAnnotations;

namespace DrillShopApi.Models.Requests.Warehouse
{
    /// <summary>
    /// Запрос на изменение позиции склада.
    /// </summary>
    public class UpdateWarehouseRequest : CreateWarehouseRequest
    {
        /// <summary>
        /// Идентификатор сущности.
        /// </summary>
        [Required]
        public long Id { get; set; }
    }
}