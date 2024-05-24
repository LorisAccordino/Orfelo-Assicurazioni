using InsuranceCustomerManager.Console;

namespace InsuranceCustomerManager.GUI
{
    public partial class EntryDialog : Form
    {
        public BindingSource BindingSource { get; } = [];

        public EntryDialog()
        {
            InitializeComponent();
        }

        private void EntryDialog_Load(object sender, EventArgs e)
        {
            using (var context = new InsuranceDbContext())
            {
                context.Database.EnsureCreated(); // Ensure the DB exist
                BindingSource.DataSource = context.Customers.ToList(); // Add the entity to the context

                // Add the bindings
                txtName.DataBindings.Add("Text", BindingSource, "Name", true, DataSourceUpdateMode.OnPropertyChanged, null);
                txtSurname.DataBindings.Add("Text", BindingSource, "Surname", true, DataSourceUpdateMode.OnPropertyChanged, null);
                dateTimePickerDob.DataBindings.Add("Value", BindingSource, "DateOfBirth", true, DataSourceUpdateMode.OnPropertyChanged, null);
                cmbxSex.DataBindings.Add("Text", BindingSource, "Sex", true, DataSourceUpdateMode.OnPropertyChanged, null);
                txtPob.DataBindings.Add("Text", BindingSource, "PlaceOfBirth", true, DataSourceUpdateMode.OnPropertyChanged, null);
                txtResCity.DataBindings.Add("Text", BindingSource, "CityOfResidence", true, DataSourceUpdateMode.OnPropertyChanged, null);
                txtVehicle.DataBindings.Add("Text", BindingSource, "Vehicle", true, DataSourceUpdateMode.OnPropertyChanged, null);
                txtPlate.DataBindings.Add("Text", BindingSource, "Plate", true, DataSourceUpdateMode.OnPropertyChanged, null);

                //load = false;
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            BindingSource.AddNew();
            Close();
        }
    }
}
