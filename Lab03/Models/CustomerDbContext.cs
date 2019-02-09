using System.Data.Entity;

namespace Lab03.Models
{
    public class CustomerDbContext: DbContext
    {
        public DbSet<Customer> Customers { get; set; }
    }
}