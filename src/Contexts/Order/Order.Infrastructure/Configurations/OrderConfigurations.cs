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
                .HasField("OrderDate")
                .IsRequired();
        }
    }
}
