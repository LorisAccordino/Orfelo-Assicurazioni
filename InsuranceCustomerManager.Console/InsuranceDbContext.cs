using Microsoft.EntityFrameworkCore;

namespace InsuranceCustomerManager.Console
{
    internal class InsuranceDbContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder OptionsBuilder)
        {
            OptionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=Insurancedb;Trusted_Connection=True;");
        }
    }
}
