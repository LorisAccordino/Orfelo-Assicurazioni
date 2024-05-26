using InsuranceCustomerManager.Console;
using InsuranceCustomerManager.Console.Attributes;
using Microsoft.EntityFrameworkCore;
using System.Runtime.Serialization;
using System.Windows.Forms;

namespace InsuranceCustomerManager.GUI
{
    public partial class MainForm : Form
    {
        private InsuranceDbContext context;
        private BindingSource bindingSource;
        private SplashScreen splashScreen = new SplashScreen();

        public MainForm()
        {
            Thread t = new Thread(() => Application.Run(splashScreen));
            t.Start();

            InitializeComponent();

            context = new InsuranceDbContext();
            context.Database.EnsureCreated();

            bindingSource = new BindingSource();
            dgvCustomers.AutoGenerateColumns = true;
            dgvCustomers.DataSource = bindingSource;

            LoadData();
            CustomizeDataGridView<Customer>(dgvCustomers);

            if (splashScreen != null && !splashScreen.IsDisposed)
            {
                splashScreen.Invoke(new Action(splashScreen.Close));
            }

            WindowState = FormWindowState.Minimized;
            Show();
            WindowState = FormWindowState.Normal;
        }

        private void LoadData()
        {
            context.Customers.Load();
            bindingSource.DataSource = context.Customers.Local.ToBindingList();
        }

        private void CustomizeDataGridView<T>(DataGridView dataGridView)
        {
            dataGridView.AutoGenerateColumns = false;
            dataGridView.Columns.Clear();

            var properties = typeof(T).GetProperties();
            foreach (var property in properties)
            {
                var visibilityAttr = property.GetCustomAttributes(typeof(ColumnVisibilityAttribute), false)
                                             .FirstOrDefault() as ColumnVisibilityAttribute;

                var headerAttr = property.GetCustomAttributes(typeof(ColumnHeaderAttribute), false)
                                         .FirstOrDefault() as ColumnHeaderAttribute;

                var formatAttr = property.GetCustomAttributes(typeof(ColumnFormatAttribute), false)
                                 .FirstOrDefault() as ColumnFormatAttribute;

                var isVisible = visibilityAttr?.IsVisible ?? true;
                var headerText = headerAttr?.HeaderText ?? property.Name;
                var format = formatAttr?.Format ?? string.Empty;

                var column = new DataGridViewTextBoxColumn
                {
                    DataPropertyName = property.Name,
                    HeaderText = headerText,
                    Visible = isVisible
                };

                if (!string.IsNullOrEmpty(format))
                {
                    column.DefaultCellStyle.Format = format;
                }

                dataGridView.Columns.Add(column);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (CustomerDialog dialog = new CustomerDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    context.Customers.Add(dialog.Customer);
                    context.SaveChanges();
                    LoadData();
                }
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (bindingSource.Current is Customer selectedCustomer)
            {
                var result = MessageBox.Show("Sei sicuro di voler eliminare questo cliente?", "Conferma Eliminazione", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    context.Customers.Remove(selectedCustomer);
                    context.SaveChanges();

                    LoadData();
                }
            }
            else
            {
                MessageBox.Show("Seleziona un cliente da eliminare.");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (bindingSource.Current is Customer selectedCustomer)
            {
                using (CustomerDialog dialog = new CustomerDialog(selectedCustomer))
                {
                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        context.Customers.Update(selectedCustomer);
                        context.SaveChanges();

                        LoadData();
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleziona un cliente da modificare.");
            }
        }
    }
}
