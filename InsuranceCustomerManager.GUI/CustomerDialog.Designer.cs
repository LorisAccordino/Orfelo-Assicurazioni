namespace InsuranceCustomerManager.GUI
{
    partial class CustomerDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblName = new Label();
            lblSurname = new Label();
            txtName = new TextBox();
            txtSurname = new TextBox();
            lblDob = new Label();
            dateTimePickerDob = new DateTimePicker();
            lblPob = new Label();
            lblVehicle = new Label();
            lblPlate = new Label();
            label5 = new Label();
            lblSex = new Label();
            cmbxSex = new ComboBox();
            txtVehicle = new ComboBox();
            radioBtnItaly = new RadioButton();
            radioBtnAbroad = new RadioButton();
            txtPob = new TextBox();
            txtPlate = new TextBox();
            txtResCity = new TextBox();
            lblResCity = new Label();
            picLogo = new PictureBox();
            btnSubmit = new Button();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Sylfaen", 9F, FontStyle.Bold);
            lblName.Location = new Point(7, 7);
            lblName.Name = "lblName";
            lblName.Size = new Size(55, 19);
            lblName.TabIndex = 0;
            lblName.Text = "Nome:";
            // 
            // lblSurname
            // 
            lblSurname.AutoSize = true;
            lblSurname.Font = new Font("Sylfaen", 9F, FontStyle.Bold);
            lblSurname.Location = new Point(251, 7);
            lblSurname.Name = "lblSurname";
            lblSurname.Size = new Size(79, 19);
            lblSurname.TabIndex = 1;
            lblSurname.Text = "Cognome:";
            // 
            // txtName
            // 
            txtName.Location = new Point(7, 32);
            txtName.Margin = new Padding(3, 4, 3, 4);
            txtName.Name = "txtName";
            txtName.Size = new Size(204, 27);
            txtName.TabIndex = 2;
            // 
            // txtSurname
            // 
            txtSurname.Location = new Point(251, 32);
            txtSurname.Margin = new Padding(3, 4, 3, 4);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(204, 27);
            txtSurname.TabIndex = 3;
            // 
            // lblDob
            // 
            lblDob.AutoSize = true;
            lblDob.Font = new Font("Sylfaen", 9F, FontStyle.Bold);
            lblDob.Location = new Point(7, 79);
            lblDob.Name = "lblDob";
            lblDob.Size = new Size(120, 19);
            lblDob.TabIndex = 4;
            lblDob.Text = "Data di nascita:";
            // 
            // dateTimePickerDob
            // 
            dateTimePickerDob.CustomFormat = "MMMM dd yyyy";
            dateTimePickerDob.Format = DateTimePickerFormat.Custom;
            dateTimePickerDob.Location = new Point(7, 104);
            dateTimePickerDob.Margin = new Padding(3, 4, 3, 4);
            dateTimePickerDob.Name = "dateTimePickerDob";
            dateTimePickerDob.Size = new Size(204, 27);
            dateTimePickerDob.TabIndex = 5;
            dateTimePickerDob.Value = new DateTime(2024, 5, 24, 10, 52, 27, 0);
            // 
            // lblPob
            // 
            lblPob.AutoSize = true;
            lblPob.Font = new Font("Sylfaen", 9F, FontStyle.Bold);
            lblPob.Location = new Point(7, 151);
            lblPob.Name = "lblPob";
            lblPob.Size = new Size(121, 19);
            lblPob.TabIndex = 6;
            lblPob.Text = "Città di nascita:";
            // 
            // lblVehicle
            // 
            lblVehicle.AutoSize = true;
            lblVehicle.Font = new Font("Sylfaen", 9F, FontStyle.Bold);
            lblVehicle.Location = new Point(7, 292);
            lblVehicle.Name = "lblVehicle";
            lblVehicle.Size = new Size(120, 19);
            lblVehicle.TabIndex = 10;
            lblVehicle.Text = "Tipo di veicolo:";
            // 
            // lblPlate
            // 
            lblPlate.AutoSize = true;
            lblPlate.Font = new Font("Sylfaen", 9F, FontStyle.Bold);
            lblPlate.Location = new Point(251, 292);
            lblPlate.Name = "lblPlate";
            lblPlate.Size = new Size(110, 19);
            lblPlate.TabIndex = 11;
            lblPlate.Text = "Targa veicolo:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Sylfaen", 9F, FontStyle.Bold);
            label5.Location = new Point(317, 253);
            label5.Name = "label5";
            label5.Size = new Size(0, 19);
            label5.TabIndex = 12;
            // 
            // lblSex
            // 
            lblSex.AutoSize = true;
            lblSex.Font = new Font("Sylfaen", 9F, FontStyle.Bold);
            lblSex.Location = new Point(253, 79);
            lblSex.Name = "lblSex";
            lblSex.Size = new Size(53, 19);
            lblSex.TabIndex = 15;
            lblSex.Text = "Sesso:";
            // 
            // cmbxSex
            // 
            cmbxSex.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbxSex.FormattingEnabled = true;
            cmbxSex.Items.AddRange(new object[] { "M", "F" });
            cmbxSex.Location = new Point(251, 103);
            cmbxSex.Margin = new Padding(3, 4, 3, 4);
            cmbxSex.Name = "cmbxSex";
            cmbxSex.Size = new Size(74, 28);
            cmbxSex.TabIndex = 16;
            // 
            // txtVehicle
            // 
            txtVehicle.DropDownStyle = ComboBoxStyle.DropDownList;
            txtVehicle.FormattingEnabled = true;
            txtVehicle.Items.AddRange(new object[] { "- Automobile", "- Moto", "- Scooter", "- Ciclomotori", "- Furgoni", "- Camion", "- Autocarri leggeri", "- Autocarri pesanti", "- Trattori", "- Mietitrebbie", "- Macchine agricole", "- Camper", "- Roulotte", "- Carrelli da campeggio", "- Autobus", "- Taxi", "- Minibus", "- Ambulanze", "- Veicoli di emergenza", "- Veicoli blindati", "- Biciclette", "- Barche", "- Yacht", "- Moto d'acqua", "- Aeroplani leggeri", "- Elicotteri privati", "- Carrozzine motorizzate", "- Veicoli adattati" });
            txtVehicle.Location = new Point(7, 317);
            txtVehicle.Margin = new Padding(3, 4, 3, 4);
            txtVehicle.Name = "txtVehicle";
            txtVehicle.Size = new Size(204, 28);
            txtVehicle.TabIndex = 17;
            // 
            // radioBtnItaly
            // 
            radioBtnItaly.AutoSize = true;
            radioBtnItaly.Checked = true;
            radioBtnItaly.Location = new Point(253, 177);
            radioBtnItaly.Margin = new Padding(3, 4, 3, 4);
            radioBtnItaly.Name = "radioBtnItaly";
            radioBtnItaly.Size = new Size(63, 24);
            radioBtnItaly.TabIndex = 18;
            radioBtnItaly.TabStop = true;
            radioBtnItaly.Text = "Italia";
            radioBtnItaly.UseVisualStyleBackColor = true;
            radioBtnItaly.Visible = false;
            // 
            // radioBtnAbroad
            // 
            radioBtnAbroad.AutoSize = true;
            radioBtnAbroad.Location = new Point(317, 177);
            radioBtnAbroad.Margin = new Padding(3, 4, 3, 4);
            radioBtnAbroad.Name = "radioBtnAbroad";
            radioBtnAbroad.Size = new Size(71, 24);
            radioBtnAbroad.TabIndex = 19;
            radioBtnAbroad.Text = "Estero";
            radioBtnAbroad.UseVisualStyleBackColor = true;
            radioBtnAbroad.Visible = false;
            // 
            // txtPob
            // 
            txtPob.Location = new Point(7, 176);
            txtPob.Margin = new Padding(3, 4, 3, 4);
            txtPob.Name = "txtPob";
            txtPob.Size = new Size(204, 27);
            txtPob.TabIndex = 20;
            // 
            // txtPlate
            // 
            txtPlate.Location = new Point(251, 317);
            txtPlate.Margin = new Padding(3, 4, 3, 4);
            txtPlate.Name = "txtPlate";
            txtPlate.Size = new Size(204, 27);
            txtPlate.TabIndex = 21;
            // 
            // txtResCity
            // 
            txtResCity.Location = new Point(7, 244);
            txtResCity.Margin = new Padding(3, 4, 3, 4);
            txtResCity.Name = "txtResCity";
            txtResCity.Size = new Size(204, 27);
            txtResCity.TabIndex = 25;
            // 
            // lblResCity
            // 
            lblResCity.AutoSize = true;
            lblResCity.Font = new Font("Sylfaen", 9F, FontStyle.Bold);
            lblResCity.Location = new Point(7, 219);
            lblResCity.Name = "lblResCity";
            lblResCity.Size = new Size(138, 19);
            lblResCity.TabIndex = 22;
            lblResCity.Text = "Città di residenza:";
            // 
            // picLogo
            // 
            picLogo.Image = Properties.Resources.asslogo2_removebg_preview;
            picLogo.Location = new Point(253, 211);
            picLogo.Margin = new Padding(3, 4, 3, 4);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(129, 77);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 26;
            picLogo.TabStop = false;
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = SystemColors.InactiveCaption;
            btnSubmit.Font = new Font("Sylfaen", 9F, FontStyle.Bold);
            btnSubmit.Location = new Point(7, 377);
            btnSubmit.Margin = new Padding(3, 4, 3, 4);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(449, 44);
            btnSubmit.TabIndex = 27;
            btnSubmit.Text = "Invia";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // CustomerDialog
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(471, 437);
            Controls.Add(btnSubmit);
            Controls.Add(picLogo);
            Controls.Add(txtResCity);
            Controls.Add(lblResCity);
            Controls.Add(txtPlate);
            Controls.Add(txtPob);
            Controls.Add(radioBtnAbroad);
            Controls.Add(radioBtnItaly);
            Controls.Add(txtVehicle);
            Controls.Add(cmbxSex);
            Controls.Add(lblSex);
            Controls.Add(label5);
            Controls.Add(lblPlate);
            Controls.Add(lblVehicle);
            Controls.Add(lblPob);
            Controls.Add(dateTimePickerDob);
            Controls.Add(lblDob);
            Controls.Add(txtSurname);
            Controls.Add(txtName);
            Controls.Add(lblSurname);
            Controls.Add(lblName);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 4, 3, 4);
            Name = "CustomerDialog";
            Text = "EntryDialog";
            Load += EntryDialog_Load;
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private Label lblSurname;
        private TextBox txtName;
        private TextBox txtSurname;
        private Label lblDob;
        private DateTimePicker dateTimePickerDob;
        private Label lblPob;
        private Label lblVehicle;
        private Label lblPlate;
        private Label label5;
        private Label lblSex;
        private ComboBox cmbxSex;
        private ComboBox txtVehicle;
        private RadioButton radioBtnItaly;
        private RadioButton radioBtnAbroad;
        private TextBox txtPob;
        private TextBox txtPlate;
        private TextBox txtResCity;
        private Label lblResCity;
        private PictureBox picLogo;
        private Button btnSubmit;
    }
}