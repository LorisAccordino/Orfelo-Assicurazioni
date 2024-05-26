using InsuranceCustomerManager.Console;
using InsuranceCustomerManager.Console.Attributes;
using Microsoft.EntityFrameworkCore;

namespace InsuranceCustomerManager.GUI
{
    public partial class MainForm : Form
    {
        private InsuranceDbContext context;
        private BindingSource bindingSource;
        private SplashScreen splashScreen = new SplashScreen();

        public MainForm()
        {
            // Fai partire un thread con lo splash screen
            Thread t = new Thread(() => Application.Run(splashScreen));
            t.Start();

            InitializeComponent();

            // Inizializza il contesto del database
            context = new InsuranceDbContext();
            context.Database.EnsureCreated();

            // Inizializza il binding source per la DataGridView
            bindingSource = new BindingSource();
            dgvCustomers.AutoGenerateColumns = false;
            dgvCustomers.DataSource = bindingSource;

            // Carica i dati dalla tabella Customers,
            // personalizza la DataGridView in base all'entità Customer
            LoadData();
            CustomizeDataGridView<Customer>(dgvCustomers);

            // Chiudi lo splash screen (e il thread) dopo il caricamento
            if (splashScreen != null && !splashScreen.IsDisposed)
            {
                splashScreen.Invoke(new Action(splashScreen.Close));
                t.Join();
            }

            // Inizializza i controlli utente della finestra principale
            InitializeComponent();

            // Visualizza la finestra principale minimizzata e poi normalizzata per assicurare il "bring to front"
            WindowState = FormWindowState.Minimized;
            Show();
            WindowState = FormWindowState.Normal;
        }

        // Metodo per caricare i dati dalla tabella Customers nel binding source
        private void LoadData()
        {
            context.Customers.Load();
            bindingSource.DataSource = context.Customers.Local.ToBindingList();
        }

        // Metodo per personalizzare le colonne della DataGridView in base all'entità specificata
        private void CustomizeDataGridView<T>(DataGridView dataGridView)
        {
            dataGridView.Columns.Clear();

            // Ottiene le proprietà dell'entità specificata
            var properties = typeof(T).GetProperties();
            foreach (var property in properties)
            {
                // Ottiene gli attributi personalizzati per la visibilità, l'intestazione e il formato della colonna
                var visibilityAttr = property.GetCustomAttributes(typeof(ColumnVisibilityAttribute), false)
                                             .FirstOrDefault() as ColumnVisibilityAttribute;

                var headerAttr = property.GetCustomAttributes(typeof(ColumnHeaderAttribute), false)
                                         .FirstOrDefault() as ColumnHeaderAttribute;

                var formatAttr = property.GetCustomAttributes(typeof(ColumnFormatAttribute), false)
                                 .FirstOrDefault() as ColumnFormatAttribute;

                // Ottiene i valori degli attributi o usa i valori predefiniti se non specificati
                var isVisible = visibilityAttr?.IsVisible ?? true;
                var headerText = headerAttr?.HeaderText ?? property.Name;
                var format = formatAttr?.Format ?? string.Empty;

                // Crea e aggiunge la colonna alla DataGridView
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

        // Gestisce il click sul pulsante Aggiungi
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Apre la finestra di dialogo per aggiungere un nuovo cliente
            using (CustomerDialog dialog = new CustomerDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    // Aggiunge il nuovo cliente al contesto del database e salva le modifiche
                    context.Customers.Add(dialog.Customer);
                    context.SaveChanges();
                    LoadData();
                }
            }
        }

        // Gestisce il click sul pulsante Elimina
        private void btnDel_Click(object sender, EventArgs e)
        {
            // Ottiene il cliente selezionato dalla DataGridView
            if (bindingSource.Current is Customer selectedCustomer)
            {
                // Mostra un messaggio di conferma per l'eliminazione del cliente
                var result = MessageBox.Show("Sei sicuro di voler eliminare questo cliente?", "Conferma Eliminazione", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    // Rimuove il cliente dal contesto del database e salva le modifiche
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

        // Gestisce il click sul pulsante Modifica
        private void btnEdit_Click(object sender, EventArgs e)
        {
            // Ottiene il cliente selezionato dalla DataGridView
            if (bindingSource.Current is Customer selectedCustomer)
            {
                // Apre la finestra di dialogo per modificare il cliente selezionato
                using (CustomerDialog dialog = new CustomerDialog(selectedCustomer))
                {
                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        // Aggiorna il cliente nel contesto del database e salva le modifiche
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
