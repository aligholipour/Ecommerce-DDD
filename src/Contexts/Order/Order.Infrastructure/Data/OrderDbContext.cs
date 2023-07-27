using Microsoft.EntityFrameworkCore;

namespace Order.Infrastructure.Data
{
    public class OrderDbContext : DbContext
    {
        public OrderDbContext(DbContextOptions<OrderDbContext> option) : base(option)
        {
        }
    }
}
