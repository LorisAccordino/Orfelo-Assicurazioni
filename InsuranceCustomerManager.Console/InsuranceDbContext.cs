using Microsoft.EntityFrameworkCore;

namespace InsuranceCustomerManager.Console
{
    public class InsuranceDbContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=InsuranceDB;Trusted_Connection=True;");
        }
    }
}
