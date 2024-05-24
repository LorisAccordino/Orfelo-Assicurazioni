namespace InsuranceCustomerManager.GUI
{
    partial class EntryDialog
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
            label1 = new Label();
            label2 = new Label();
            txtName = new TextBox();
            txtSurname = new TextBox();
            label3 = new Label();
            dateTimeDob = new DateTimePicker();
            label4 = new Label();
            label8 = new Label();
            label9 = new Label();
            label5 = new Label();
            label11 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sylfaen", 9F, FontStyle.Bold);
            label1.Location = new Point(6, 5);
            label1.Name = "label1";
            label1.Size = new Size(44, 16);
            label1.TabIndex = 0;
            label1.Text = "Nome:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sylfaen", 9F, FontStyle.Bold);
            label2.Location = new Point(220, 5);
            label2.Name = "label2";
            label2.Size = new Size(65, 16);
            label2.TabIndex = 1;
            label2.Text = "Cognome:";
            // 
            // txtName
            // 
            txtName.Location = new Point(6, 24);
            txtName.Name = "txtName";
            txtName.Size = new Size(179, 23);
            txtName.TabIndex = 2;
            // 
            // txtSurname
            // 
            txtSurname.Location = new Point(220, 24);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(179, 23);
            txtSurname.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sylfaen", 9F, FontStyle.Bold);
            label3.Location = new Point(6, 59);
            label3.Name = "label3";
            label3.Size = new Size(96, 16);
            label3.TabIndex = 4;
            label3.Text = "Data di nascita:";
            // 
            // dateTimeDob
            // 
            dateTimeDob.CustomFormat = "";
            dateTimeDob.Location = new Point(6, 78);
            dateTimeDob.Name = "dateTimeDob";
            dateTimeDob.Size = new Size(179, 23);
            dateTimeDob.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sylfaen", 9F, FontStyle.Bold);
            label4.Location = new Point(6, 113);
            label4.Name = "label4";
            label4.Size = new Size(98, 16);
            label4.TabIndex = 6;
            label4.Text = "Città di nascita:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Sylfaen", 9F, FontStyle.Bold);
            label8.Location = new Point(6, 219);
            label8.Name = "label8";
            label8.Size = new Size(98, 16);
            label8.TabIndex = 10;
            label8.Text = "Tipo di veicolo:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Sylfaen", 9F, FontStyle.Bold);
            label9.Location = new Point(220, 219);
            label9.Name = "label9";
            label9.Size = new Size(90, 16);
            label9.TabIndex = 11;
            label9.Text = "Targa veicolo:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Sylfaen", 9F, FontStyle.Bold);
            label5.Location = new Point(277, 190);
            label5.Name = "label5";
            label5.Size = new Size(0, 16);
            label5.TabIndex = 12;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Sylfaen", 9F, FontStyle.Bold);
            label11.Location = new Point(220, 59);
            label11.Name = "label11";
            label11.Size = new Size(42, 16);
            label11.TabIndex = 15;
            label11.Text = "Sesso:";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "M", "F" });
            comboBox1.Location = new Point(220, 81);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(65, 23);
            comboBox1.TabIndex = 16;
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "- Automobile", "- Moto", "- Scooter", "- Ciclomotori", "- Furgoni", "- Camion", "- Autocarri leggeri", "- Autocarri pesanti", "- Trattori", "- Mietitrebbie", "- Macchine agricole", "- Camper", "- Roulotte", "- Carrelli da campeggio", "- Autobus", "- Taxi", "- Minibus", "- Ambulanze", "- Veicoli di emergenza", "- Veicoli blindati", "- Biciclette", "- Barche", "- Yacht", "- Moto d'acqua", "- Aeroplani leggeri", "- Elicotteri privati", "- Carrozzine motorizzate", "- Veicoli adattati" });
            comboBox2.Location = new Point(6, 238);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(179, 23);
            comboBox2.TabIndex = 17;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Location = new Point(221, 133);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(50, 19);
            radioButton1.TabIndex = 18;
            radioButton1.TabStop = true;
            radioButton1.Text = "Italia";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(277, 133);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(57, 19);
            radioButton2.TabIndex = 19;
            radioButton2.Text = "Estero";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(6, 132);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(179, 23);
            textBox3.TabIndex = 20;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(220, 238);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(179, 23);
            textBox4.TabIndex = 21;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(6, 183);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(179, 23);
            textBox5.TabIndex = 25;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Sylfaen", 9F, FontStyle.Bold);
            label6.Location = new Point(6, 164);
            label6.Name = "label6";
            label6.Size = new Size(114, 16);
            label6.TabIndex = 22;
            label6.Text = "Città di residenza:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.asslogo2_removebg_preview;
            pictureBox1.Location = new Point(221, 158);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(113, 58);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 26;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.InactiveCaption;
            button1.Font = new Font("Sylfaen", 9F, FontStyle.Bold);
            button1.Location = new Point(6, 283);
            button1.Name = "button1";
            button1.Size = new Size(393, 33);
            button1.TabIndex = 27;
            button1.Text = "Invia";
            button1.UseVisualStyleBackColor = false;
            // 
            // EntryDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(412, 328);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(textBox5);
            Controls.Add(label6);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(label11);
            Controls.Add(label5);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label4);
            Controls.Add(dateTimeDob);
            Controls.Add(label3);
            Controls.Add(txtSurname);
            Controls.Add(txtName);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "EntryDialog";
            Text = "EntryDialog";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtName;
        private TextBox txtSurname;
        private Label label3;
        private DateTimePicker dateTimeDob;
        private Label label4;
        private Label label8;
        private Label label9;
        private Label label5;
        private Label label11;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Label label6;
        private PictureBox pictureBox1;
        private Button button1;
    }
}