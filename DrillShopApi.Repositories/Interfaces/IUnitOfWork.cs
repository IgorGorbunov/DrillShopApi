namespace DrillShopApi.Repositories.Interfaces
{
    /// <summary>
    /// Интерфейс класса UoW.
    /// </summary>
    public interface IUnitOfWork
    {
        IDrillRepository DrillRepository { get; }
        IProviderRepository ProviderRepository { get; }
        IShopRepository ShopRepository { get; }
        IWarehouseRepository WarehouseRepository { get; }
        void Save();
    }
}
