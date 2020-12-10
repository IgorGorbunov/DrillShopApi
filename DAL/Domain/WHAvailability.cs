namespace DrillShopApi.DAL.Domain
{
    /// <summary>
    /// Наличие инструмента на складе.
    /// </summary>
    public class WHAvailability : BaseEntityWithLinks<Drill, Warehouse>
    {
        /// <summary>
        /// Количество доступных единиц.
        /// </summary>
        public int Count { get; set; }
    }
}
