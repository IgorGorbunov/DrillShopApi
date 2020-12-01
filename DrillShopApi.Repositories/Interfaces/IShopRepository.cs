using DrillShopApi.DAL.Domain;
using DrillShopApi.Models.DTO;
using DrillShopApi.Repositories.Interfaces.CRUD;

namespace DrillShopApi.Repositories.Interfaces
{
    /// <summary>
    /// Интерфейс репозитория для работы с сущностями "Магазин".
    /// </summary>
    public interface IShopRepository : ICrudRepository<ShopDto, Shop>
    {
    }
}
