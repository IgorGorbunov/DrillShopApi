namespace DrillShopApi.Models.Responses
{
    /// <summary>
    /// Ответ на запросы для позиций сверла.
    /// </summary>
    public class WarehouseResponse
    {
        /// <summary>
        /// Наименование.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Город.
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// Адрес.
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// Площадь помещения.
        /// </summary>
        public double Area { get; set; }

        /// <summary>
        /// Вместимость помещения.
        /// </summary>
        public double Capacity { get; set; }
    }
}
