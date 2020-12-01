namespace DrillShopApi.Models.Responses
{
    /// <summary>
    /// Ответ на запросы для позиций сверла.
    /// </summary>
    public class DrillResponse
    {
        /// <summary>
        /// Артикул.
        /// </summary>
        public string ArtCode { get; set; }

        /// <summary>
        /// Описание.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Вес.
        /// </summary>
        public double Weight { get; set; }

        /// <summary>
        /// Минимальный диаметр.
        /// </summary>
        public double MinDiametr { get; set; }

        /// <summary>
        /// Максимальный диаметр.
        /// </summary>
        public double MaxDiametr { get; set; }
    }
}
