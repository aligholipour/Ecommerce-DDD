using Microsoft.EntityFrameworkCore;
using Order.Domain.Entities.Orders;

namespace Order.Infrastructure.Data
{
    public class OrderDbContext : DbContext
    {
        public OrderDbContext(DbContextOptions<OrderDbContext> option) : base(option)
        {
        }

        public DbSet<Domain.Entities.Orders.Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
    }
}
