using DrillShopApi.DAL.Domain;
using Microsoft.EntityFrameworkCore;

namespace DrillShopApi.DAL.Contexts
{
    /// <summary>
    /// Контекст для работы с данными БД "Магазины сверл".
    /// </summary>
    public class DrillShopContext : DbContext
    {
        /// <summary>
        /// Магазины.
        /// </summary>
        public DbSet<Shop> Shops { get; set; }

        /// <summary>
        /// Поставщики.
        /// </summary>
        public DbSet<Provider> Providers { get; set; }

        /// <summary>
        /// Склады.
        /// </summary>
        public DbSet<Warehouse> Warehouses { get; set; }

        /// <summary>
        /// Сверла.
        /// </summary>
        public DbSet<Drill> Drills { get; set; }

        /// <summary>
        /// Наличие в магазинах.
        /// </summary>
        public DbSet<ShopAvailability> ShopAvailabilities { get; set; }

        /// <summary>
        /// Наличие на складах.
        /// </summary>
        public DbSet<WHAvailability> WHAvailabilities { get; set; }

        /// <summary>
        /// Инициализирует экземпляр <see cref="DrillShopContext"/>.
        /// </summary>
        /// <param name="options">Опции для конфигурации контекста.</param>
        public DrillShopContext(DbContextOptions options) : base(options)
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }
    }
}