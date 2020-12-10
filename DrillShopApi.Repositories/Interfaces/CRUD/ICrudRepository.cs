using DrillShopApi.DAL.Contexts;

namespace DrillShopApi.Repositories.Interfaces.CRUD
{
    /// <summary>
    /// Интерфейс репозитория с базовыми CRUD-операциями.
    /// </summary>
    /// <typeparam name="TDto">DTO.</typeparam>
    /// <typeparam name="TModel">Model.</typeparam>
    public interface ICrudRepository<TDto, TModel> :
        ICreatable<TDto, TModel>,
        IGettableById<TDto, TModel>,
        IGettable<TDto, TModel>,
        IUpdatable<TDto, TModel>,
        IDeletable
    {
        DrillShopContext Context { get; }
    }
}
