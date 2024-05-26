using InsuranceCustomerManager.Console;
using System.ComponentModel;

namespace InsuranceCustomerManager.GUI
{
    /// <summary>
    /// Finestra di dialogo per la gestione dei clienti.
    /// </summary>
    public partial class CustomerDialog : Form
    {
        private BindingSource bindingSource = new BindingSource();
        private ErrorProvider errorProvider = new ErrorProvider();

        // Proprietà per accedere al cliente associato alla finestra di dialogo
        public Customer Customer { get; set; }

        // Costruttore senza parametri, crea un nuovo cliente vuoto
        public CustomerDialog() : this(new Customer())
        {
            ResetFields();
            ControlBox = true;
        }

        // Costruttore che accetta un cliente esistente
        public CustomerDialog(Customer customer)
        {
            InitializeComponent();
            Customer = customer;

            // Inizializza i binding dei dati e la validazione dei campi
            InitializeBindings();
            InitializeValidation();
        }

        // Inizializza i binding dei dati tra i controlli e l'entità cliente
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

        // Resetta i campi della finestra di dialogo ai valori predefiniti
        private void ResetFields()
        {
            dateTimePickerDob.Value = DateTime.Now;
            Customer.DateOfBirth = dateTimePickerDob.Value;

            cmbxSex.SelectedItem = cmbxSex.Items[0];
            cmbxVehicle.SelectedItem = cmbxVehicle.Items[0];
        }

        // Inizializza la validazione dei campi obbligatori
        private void InitializeValidation()
        {
            txtName.Validating += new CancelEventHandler(ValidateRequiredField);
            txtSurname.Validating += new CancelEventHandler(ValidateRequiredField);
            txtBirthCity.Validating += new CancelEventHandler(ValidateRequiredField);
            txtResCity.Validating += new CancelEventHandler(ValidateRequiredField);
            txtPlate.Validating += new CancelEventHandler(ValidateRequiredField);
        }

        // Gestisce la validazione dei campi obbligatori
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

        // Gestisce il clic sul pulsante di invio
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Se tutti i controlli sono validi, chiude la finestra di dialogo con DialogResult.OK
            if (ValidateChildren())
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
