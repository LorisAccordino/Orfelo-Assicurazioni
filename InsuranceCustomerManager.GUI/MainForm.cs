using InsuranceCustomerManager.Console;
using Microsoft.EntityFrameworkCore;
using System.Drawing.Text;
using System.Threading;
using System.Windows.Forms;

namespace InsuranceCustomerManager.GUI
{
    public partial class MainForm : Form
    {
        private InsuranceDbContext context;
        private BindingSource bindingSource;
        private CustomerDialog dialog = new CustomerDialog();

        private SplashScreen splashScreen = new SplashScreen();

        public MainForm()
        {
            Thread t = new Thread(() =>
            {
                Application.Run(splashScreen);
            });
            t.Start();
            Thread.Sleep(1000);

            InitializeComponent();

            context = new InsuranceDbContext();
            context.Database.EnsureCreated();

            bindingSource = new BindingSource();
            dgvCustomers.AutoGenerateColumns = true;
            dgvCustomers.DataSource = bindingSource;

            LoadData();

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
