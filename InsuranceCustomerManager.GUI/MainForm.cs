using InsuranceCustomerManager.Console;
using Microsoft.EntityFrameworkCore;
using System.Windows.Forms;

namespace InsuranceCustomerManager.GUI
{
    public partial class MainForm : Form
    {
        private InsuranceDbContext context;
        private BindingSource bindingSource;
        private CustomerDialog dialog = new CustomerDialog();

        public MainForm()
        {
            InitializeComponent();

            context = new InsuranceDbContext();
            context.Database.EnsureCreated();

            bindingSource = new BindingSource();
            dgvCustomers.AutoGenerateColumns = true;
            dgvCustomers.DataSource = bindingSource;

            LoadData();
        }

        private void LoadData()
        {
            context.Customers.Load();
            bindingSource.DataSource = context.Customers.Local.ToBindingList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                context.Customers.Add(dialog.Customer);
                context.SaveChanges();
                LoadData();
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }
    }

}
