using InsuranceCustomerManager.Console;
using System.ComponentModel;

namespace InsuranceCustomerManager.GUI
{
    public partial class CustomerDialog : Form
    {
        private BindingSource bindingSource = new BindingSource();
        private ErrorProvider errorProvider = new ErrorProvider();

        public Customer Customer { get; set; }

        public CustomerDialog() : this(new Customer())
        {
            ResetFields();
            ControlBox = true;
        }

        public CustomerDialog(Customer customer)
        {
            InitializeComponent();
            Customer = customer;
            InitializeBindings();
            InitializeValidation();
        }

        private void InitializeBindings()
        {
            bindingSource.DataSource = Customer;

            txtName.DataBindings.Add("Text", bindingSource, "Name", true, DataSourceUpdateMode.OnPropertyChanged, null);
            txtSurname.DataBindings.Add("Text", bindingSource, "Surname", true, DataSourceUpdateMode.OnPropertyChanged, null);
            dateTimePickerDob.DataBindings.Add("Value", bindingSource, "DateOfBirth", true, DataSourceUpdateMode.OnPropertyChanged, null);
            cmbxSex.DataBindings.Add("SelectedItem", bindingSource, "Sex", true, DataSourceUpdateMode.OnPropertyChanged, null);
            txtBirthCity.DataBindings.Add("Text", bindingSource, "CityOfBirth", true, DataSourceUpdateMode.OnPropertyChanged, null);
            txtResCity.DataBindings.Add("Text", bindingSource, "CityOfResidence", true, DataSourceUpdateMode.OnPropertyChanged, null);
            cmbxVehicle.DataBindings.Add("SelectedItem", bindingSource, "Vehicle", true, DataSourceUpdateMode.OnPropertyChanged, null);
            txtPlate.DataBindings.Add("Text", bindingSource, "Plate", true, DataSourceUpdateMode.OnPropertyChanged, null);
        }

        private void ResetFields()
        {
            dateTimePickerDob.Value = DateTime.Now;
            Customer.DateOfBirth = dateTimePickerDob.Value;

            cmbxSex.SelectedItem = cmbxSex.Items[0];
            cmbxVehicle.SelectedItem = cmbxVehicle.Items[0];
        }

        private void InitializeValidation()
        {
            txtName.Validating += new CancelEventHandler(ValidateRequiredField);
            txtSurname.Validating += new CancelEventHandler(ValidateRequiredField);
            txtBirthCity.Validating += new CancelEventHandler(ValidateRequiredField);
            txtResCity.Validating += new CancelEventHandler(ValidateRequiredField);
            txtPlate.Validating += new CancelEventHandler(ValidateRequiredField);
        }

        private void ValidateRequiredField(object? sender, CancelEventArgs e)
        {
            if (sender is Control control) {
                if (string.IsNullOrWhiteSpace(control.Text))
                {
                    e.Cancel = true;
                    errorProvider.SetError(control, "Campo obbligatorio!");
                }
                else
                {
                    e.Cancel = false;
                    errorProvider.SetError(control, null);
                }
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
