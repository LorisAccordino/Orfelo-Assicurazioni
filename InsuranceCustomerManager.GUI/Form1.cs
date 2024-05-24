using InsuranceCustomerManager.GUI;

namespace Insurance_Customer_Manager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           // MessageBox.Show("Il tuo nome è " + textBox2.Text + " " + textBox1.Text + " e il tuo biscotto preferito è " + comboBox1.Text + ".\nGrazie per la tua scelta!");
           EntryDialog entryDialog = new EntryDialog();
            entryDialog.ShowDialog();   
            //MessageBox.Show("Il tuo nome è " + textBox2.Text + " " + textBox1.Text + " e il tuo biscotto preferito è " + comboBox1.Text + ".\nGrazie per la tua scelta!");
        }
    }
    
}
