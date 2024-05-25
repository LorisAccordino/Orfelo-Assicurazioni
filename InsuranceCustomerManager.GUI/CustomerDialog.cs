using InsuranceCustomerManager.Console;

namespace InsuranceCustomerManager.GUI
{
    public partial class CustomerDialog : Form
    {
        private BindingSource bindingSource = new BindingSource();

        public Customer Customer { get; set; } = new Customer();

        public CustomerDialog()
        {
            InitializeComponent();

            bindingSource.DataSource = Customer;

            txtName.DataBindings.Add("Text", bindingSource, "Name", true, DataSourceUpdateMode.OnPropertyChanged, null);
            txtSurname.DataBindings.Add("Text", bindingSource, "Surname", true, DataSourceUpdateMode.OnPropertyChanged, null);
            dateTimePickerDob.DataBindings.Add("Value", bindingSource, "DateOfBirth", true, DataSourceUpdateMode.OnPropertyChanged, null);
            cmbxSex.DataBindings.Add("Text", bindingSource, "Sex", true, DataSourceUpdateMode.OnPropertyChanged, null);
            txtPob.DataBindings.Add("Text", bindingSource, "CityOfBirth", true, DataSourceUpdateMode.OnPropertyChanged, null);
            txtResCity.DataBindings.Add("Text", bindingSource, "CityOfResidence", true, DataSourceUpdateMode.OnPropertyChanged, null);
            txtVehicle.DataBindings.Add("Text", bindingSource, "Vehicle", true, DataSourceUpdateMode.OnPropertyChanged, null);
            txtPlate.DataBindings.Add("Text", bindingSource, "Plate", true, DataSourceUpdateMode.OnPropertyChanged, null);
        }

        private void EntryDialog_Load(object sender, EventArgs e)
        {
            dateTimePickerDob.Value = DateTime.Now;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
