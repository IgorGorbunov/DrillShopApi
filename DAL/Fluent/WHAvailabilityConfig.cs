using DrillShopApi.DAL.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DrillShopApi.DAL.Fluent
{
    public class WHAvailabilityConfig : IEntityTypeConfiguration<WHAvailability>
    {
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
