using DrillShopApi.DAL.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DrillShopApi.DAL.Fluent
{
    /// <summary>
    /// Конфигурация миграций для <see cref="WHAvailability"/>.
    /// </summary>
    public class WHAvailabilityConfig : IEntityTypeConfiguration<WHAvailability>
    {
        /// <summary>
        /// Конфигурирование сущности <see cref="WHAvailability"/>.
        /// </summary>
        /// <param name="builder"></param>
        public void Configure(EntityTypeBuilder<WHAvailability> builder)
        {
            builder.BaseEntityWithLinksConfig<WHAvailability, Drill, Warehouse>(
                e => e.WHAvailabilities);

            builder.Property(x => x.Count)
                .IsRequired();

            builder.ToTable("WHAvailabilities");
        }
    }
}
