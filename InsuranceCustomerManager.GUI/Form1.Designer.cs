namespace Insurance_Customer_Manager
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            panel1 = new Panel();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            comboBox1 = new ComboBox();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            button1 = new Button();
            label7 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Felix Titling", 30F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(270, 8);
            label1.Name = "label1";
            label1.Size = new Size(244, 58);
            label1.TabIndex = 0;
            label1.Text = "Biscotti";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Info;
            panel1.Controls.Add(label1);
            panel1.ForeColor = SystemColors.ControlText;
            panel1.Location = new Point(0, -3);
            panel1.Name = "panel1";
            panel1.Size = new Size(801, 77);
            panel1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Rockwell", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 252);
            label2.Name = "label2";
            label2.Size = new Size(252, 20);
            label2.TabIndex = 2;
            label2.Text = "Scrivi il tuo biscotto preferito:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = InsuranceCustomerManager.GUI.Properties.Resources.biscotti;
            pictureBox1.Location = new Point(555, 74);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(246, 376);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Biscotti al cioccolato", "Biscotti al burro", "Biscotti all'avena", "Biscotti ai cereali", "Biscotti alla cannella", "Biscotti ai frutti di bosco", "Biscotti alla nocciola", "Biscotti al cocco", "Biscotti al limone", "Biscotti alla vaniglia" });
            comboBox1.Location = new Point(12, 275);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Rockwell", 10.8F);
            label3.Location = new Point(12, 95);
            label3.Name = "label3";
            label3.Size = new Size(253, 20);
            label3.TabIndex = 5;
            label3.Text = "Scrivi il tuo nome e cognome:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(106, 188);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(243, 27);
            textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(106, 140);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(243, 27);
            textBox2.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Rockwell", 8F);
            label4.Location = new Point(12, 140);
            label4.Name = "label4";
            label4.Size = new Size(46, 17);
            label4.TabIndex = 8;
            label4.Text = "Nome";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Rockwell", 8F);
            label5.Location = new Point(12, 188);
            label5.Name = "label5";
            label5.Size = new Size(72, 17);
            label5.TabIndex = 9;
            label5.Text = "Cognome";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Rockwell", 10.8F);
            label6.Location = new Point(0, 430);
            label6.Name = "label6";
            label6.Size = new Size(557, 20);
            label6.TabIndex = 10;
            label6.Text = "------------------------------grazie per la tua scelta------------------------------";
            // 
            // button1
            // 
            button1.BackColor = Color.Lime;
            button1.Font = new Font("Felix Titling", 30F);
            button1.Location = new Point(23, 322);
            button1.Name = "button1";
            button1.Size = new Size(510, 92);
            button1.TabIndex = 11;
            button1.Text = "INVIA";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Rockwell", 7F);
            label7.Location = new Point(271, 100);
            label7.Name = "label7";
            label7.Size = new Size(140, 14);
            label7.TabIndex = 12;
            label7.Text = "*Prima lettera maiuscola";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label7);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(comboBox1);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Label label2;
        private PictureBox pictureBox1;
        private ComboBox comboBox1;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button button1;
        private Label label7;
    }
}
