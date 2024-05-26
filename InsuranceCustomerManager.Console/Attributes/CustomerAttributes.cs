namespace InsuranceCustomerManager.Console.Attributes
{

    [AttributeUsage(AttributeTargets.Property)]
    public class ColumnHeaderAttribute : Attribute
    {
        public string HeaderText { get; }

        public ColumnHeaderAttribute(string headerText)
        {
            HeaderText = headerText;
        }
    }


    [AttributeUsage(AttributeTargets.Property)]
    public class ColumnVisibilityAttribute : Attribute
    {
        public bool IsVisible { get; }

        public ColumnVisibilityAttribute(bool isVisible)
        {
            IsVisible = isVisible;
        }
    }


    [AttributeUsage(AttributeTargets.Property)]
    public class ColumnFormatAttribute : Attribute
    {
        public string Format { get; }

        public ColumnFormatAttribute(string format)
        {
            Format = format;
        }
    }
}
