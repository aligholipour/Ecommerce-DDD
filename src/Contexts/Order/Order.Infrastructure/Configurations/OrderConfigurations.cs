using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Order.Infrastructure.Configurations
{
    public class OrderConfigurations : IEntityTypeConfiguration<Domain.Entities.Orders.Order>
    {
        public void Configure(EntityTypeBuilder<Domain.Entities.Orders.Order> builder)
        {
            builder.Property<DateTime>("_orderDate")
                .UsePropertyAccessMode(PropertyAccessMode.Field)
                .HasColumnName("OrderDate")
                .IsRequired();

            builder.OwnsOne(o => o.Address, a =>
            {
                a.Property(x => x.Street).HasColumnName("Street");
                a.Property(x => x.City).HasColumnName("City");
                a.Property(x => x.State).HasColumnName("State");
                a.Property(x => x.Country).HasColumnName("Country");
                a.Property(x => x.ZipCode).HasColumnName("ZipCode");
            });
        }
    }
}
