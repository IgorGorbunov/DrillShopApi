namespace DrillShopApi.DAL.Domain
{
    /// <summary>
    /// Наличие инструмента в магазине.
    /// </summary>
    public class ShopAvailability : BaseEntityWithLinks<Drill, Shop>
    {
        /// <summary>
        /// Количество доступных единиц.
        /// </summary>
        public int Count { get; set; }
    }
}
