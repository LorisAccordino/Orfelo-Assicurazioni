namespace InsuranceCustomerManager.Console.Attributes
{
    /// <summary>
    /// Attributo utilizzato per specificare l'intestazione della colonna per una proprietà.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    public class ColumnHeaderAttribute : Attribute
    {
        /// <summary>
        /// Ottiene il testo dell'intestazione della colonna.
        /// </summary>
        public string HeaderText { get; }

        /// <summary>
        /// Crea una nuova istanza dell'attributo ColumnHeaderAttribute con il testo specificato.
        /// </summary>
        /// <param name="headerText">Il testo dell'intestazione della colonna.</param>
        public ColumnHeaderAttribute(string headerText)
        {
            HeaderText = headerText;
        }
    }

    /// <summary>
    /// Attributo utilizzato per specificare la visibilità della colonna per una proprietà.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    public class ColumnVisibilityAttribute : Attribute
    {
        /// <summary>
        /// Ottiene un valore che indica se la colonna è visibile.
        /// </summary>
        public bool IsVisible { get; }

        /// <summary>
        /// Crea una nuova istanza dell'attributo ColumnVisibilityAttribute con il valore di visibilità specificato.
        /// </summary>
        /// <param name="isVisible">True se la colonna è visibile, altrimenti False.</param>
        public ColumnVisibilityAttribute(bool isVisible)
        {
            IsVisible = isVisible;
        }
    }

    /// <summary>
    /// Attributo utilizzato per specificare il formato della colonna per una proprietà.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    public class ColumnFormatAttribute : Attribute
    {
        /// <summary>
        /// Ottiene il formato della colonna.
        /// </summary>
        public string Format { get; }

        /// <summary>
        /// Crea una nuova istanza dell'attributo ColumnFormatAttribute con il formato specificato.
        /// </summary>
        /// <param name="format">Il formato della colonna.</param>
        public ColumnFormatAttribute(string format)
        {
            Format = format;
        }
    }
}
