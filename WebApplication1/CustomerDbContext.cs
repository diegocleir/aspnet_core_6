using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Data
{
    public class CustomerDbContext : DbContext
    {
        public CustomerDbContext(DbContextOptions<CustomerDbContext> options)
            : base(options)
        {
        }

        public DbSet<WebApplication1.Models.Customer> Customer => Set<WebApplication1.Models.Customer>();
    }
}