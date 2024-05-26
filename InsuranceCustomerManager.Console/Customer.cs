using InsuranceCustomerManager.Console.Attributes;

namespace InsuranceCustomerManager.Console
{
    /// <summary>
    /// Rappresenta un cliente assicurativo.
    /// </summary>
    public class Customer
    {
        /// <summary>
        /// Ottiene o imposta l'identificativo univoco del cliente (chiave primaria della tabella).
        /// </summary>
        [ColumnVisibility(false)]
        public int CustomerId { get; set; }

        /// <summary>
        /// Ottiene o imposta il nome del cliente.
        /// </summary>
        [ColumnHeader("Nome")]
        public string Name { get; set; }

        /// <summary>
        /// Ottiene o imposta il cognome del cliente.
        /// </summary>
        [ColumnHeader("Cognome")]
        public string Surname { get; set; }

        /// <summary>
        /// Ottiene o imposta la data di nascita del cliente nel formato "gg/MM/aaaa".
        /// </summary>
        [ColumnHeader("Data di nascita")]
        [ColumnFormat("dd/MM/yyyy")]
        public DateTime DateOfBirth { get; set; }

        /// <summary>
        /// Ottiene o imposta la città di nascita del cliente.
        /// </summary>
        [ColumnHeader("Città di nascita")]
        public string CityOfBirth { get; set; }

        /// <summary>
        /// Ottiene o imposta il sesso del cliente.
        /// </summary>
        [ColumnHeader("Sesso")]
        public string Sex { get; set; }

        /// <summary>
        /// Ottiene o imposta la città di residenza del cliente.
        /// </summary>
        [ColumnHeader("Città di residenza")]
        public string CityOfResidence { get; set; }

        /// <summary>
        /// Ottiene o imposta il veicolo del cliente.
        /// </summary>
        [ColumnHeader("Veicolo")]
        public string Vehicle { get; set; }

        /// <summary>
        /// Ottiene o imposta la targa del veicolo del cliente.
        /// </summary>
        [ColumnHeader("Targa")]
        public string Plate { get; set; }
    }
}
