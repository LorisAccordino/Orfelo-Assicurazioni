namespace InsuranceCustomerManager.GUI
{
    public partial class MainForm : Form
    {
        EntryDialog entryDialog = new EntryDialog();

        bool load = true;


        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            dgvCustomers.AutoGenerateColumns = true;
            dgvCustomers.DataSource = entryDialog.BindingSource;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            entryDialog.ShowDialog();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }
    }

}
