using System.ComponentModel.DataAnnotations;

namespace DrillShopApi.Models.Requests.Drill
{
    /// <summary>
    /// Запрос на изменение позиции сверла.
    /// </summary>
    public class UpdateDrillRequest : CreateDrillRequest
    {
        /// <summary>
        /// Идентификатор сущности.
        /// </summary>
        [Required]
        public long Id { get; set; }
    }
}