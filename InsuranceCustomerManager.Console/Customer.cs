using InsuranceCustomerManager.Console.Attributes;

namespace InsuranceCustomerManager.Console
{
    public class Customer
    {
        [ColumnVisibility(false)]
        public int CustomerId { get; set; }

        [ColumnHeader("Nome")]
        public string Name { get; set; }

        [ColumnHeader("Cognome")]
        public string Surname { get; set; }

        [ColumnHeader("Data di nascita")]
        [ColumnFormat("dd/MM/yyyy")]
        public DateTime DateOfBirth { get; set; }

        [ColumnHeader("Città di nascita")]
        public string CityOfBirth { get; set; }

        [ColumnHeader("Sesso")]
        public string Sex { get; set; }


        [ColumnHeader("Città di residenza")]
        public string CityOfResidence { get; set; }

        [ColumnHeader("Veicolo")]
        public string Vehicle { get; set; }

        [ColumnHeader("Targa")]
        public string Plate { get; set; }
    }
}
