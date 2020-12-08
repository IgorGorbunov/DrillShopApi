using DrillShopApi.DAL.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DrillShopApi.DAL.Fluent
{
    /// <summary>
    /// Конфигурация миграций для <see cref="ShopAvailability"/>.
    /// </summary>
    public class ShopAvailabilityConfig : IEntityTypeConfiguration<ShopAvailability>
    {
        /// <summary>
        /// Конфигурирование сущности <see cref="ShopAvailability"/>.
        /// </summary>
        /// <param name="builder"></param>
        public void Configure(EntityTypeBuilder<ShopAvailability> builder)
        {
            builder.BaseEntityWithLinksConfig<ShopAvailability, Drill, Shop>(
                e => e.ShopAvailabilities);

            builder.Property(x => x.Count)
                .IsRequired();

            builder.ToTable("ShopAvailabilities");
        }
    }
}
