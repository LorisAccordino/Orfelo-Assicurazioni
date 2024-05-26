using Microsoft.EntityFrameworkCore;

namespace InsuranceCustomerManager.Console
{
    /// <summary>
    /// Rappresenta il contesto del database per la gestione dei clienti assicurativi.
    /// </summary>
    public class InsuranceDbContext : DbContext
    {
        /// <summary>
        /// Ottiene o imposta il set di entità per i clienti.
        /// </summary>
        public DbSet<Customer> Customers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Configura le opzioni per utilizzare SQL Server come provider di database
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=InsuranceDB;Trusted_Connection=True;");
        }
    }
}
