namespace DrillShopApi.Models.Responses
{
    /// <summary>
    /// Ответ на запросы для позиций поставщика.
    /// </summary>
    public class ProviderResponse
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
    }
}
