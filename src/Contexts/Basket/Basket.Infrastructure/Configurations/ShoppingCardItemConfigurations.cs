using Basket.Domain.Entities.ShoppingCardItems;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Basket.Infrastructure.Configurations
{
    public class ShoppingCardItemConfigurations : IEntityTypeConfiguration<ShoppingCardItem>
    {
        public void Configure(EntityTypeBuilder<ShoppingCardItem> builder)
        {
            builder.Property(sh => sh.Amount).IsRequired();
        }
    }
}
