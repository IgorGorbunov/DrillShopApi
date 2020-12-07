using DrillShopApi.DAL.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DrillShopApi.DAL.Fluent
{
    public class ShopAvailabilityConfig : IEntityTypeConfiguration<ShopAvailability>
    {
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
