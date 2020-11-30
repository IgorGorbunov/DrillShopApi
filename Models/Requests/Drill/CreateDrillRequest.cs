using System.ComponentModel.DataAnnotations;

namespace DrillShopApi.Models.Requests.Drill
{
    /// <summary>
    /// Запрос на создание позиции сверла.
    /// </summary>
    public class CreateDrillRequest
    {
        /// <summary>
        /// Артикул.
        /// </summary>
        [Required]
        public string ArtCode { get; set; }

        /// <summary>
        /// Описание.
        /// </summary>
        [MaxLength(2000)]
        public string Description { get; set; }

        /// <summary>
        /// Вес.
        /// </summary>
        [Required]
        public double Weight { get; set; }

        /// <summary>
        /// Минимальный диаметр.
        /// </summary>
        [Required]
        public double MinDiametr { get; set; }

        /// <summary>
        /// Максимальный диаметр.
        /// </summary>
        [Required]
        public double MaxDiametr { get; set; }
    }
}
