namespace InsuranceCustomerManager.Console
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string CityOfBirth { get; set; }
        public string Sex { get; set; }
        
        public string CityOfResidence { get; set; }
        public string Vehicle { get; set; }
        public string Plate { get; set; }
    }
}
