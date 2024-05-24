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
            pictureBox1 = new PictureBox();
            btnAdd = new Button();
            btnDel = new Button();
            btnEdit = new Button();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            dgvCustomers = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.InactiveCaption;
            pictureBox1.Location = new Point(1, -2);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(233, 340);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Sylfaen", 9F, FontStyle.Bold);
            btnAdd.Location = new Point(10, 65);
            btnAdd.Margin = new Padding(3, 2, 3, 2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(206, 27);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "+ Aggiungi un nuovo cliente";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += button1_Click;
            // 
            // btnDel
            // 
            btnDel.Font = new Font("Sylfaen", 9F, FontStyle.Bold);
            btnDel.Location = new Point(10, 97);
            btnDel.Margin = new Padding(3, 2, 3, 2);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(206, 27);
            btnDel.TabIndex = 2;
            btnDel.Text = "- Rimuovi un cliente";
            btnDel.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            btnEdit.Font = new Font("Sylfaen", 9F, FontStyle.Bold);
            btnEdit.Location = new Point(10, 128);
            btnEdit.Margin = new Padding(3, 2, 3, 2);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(206, 27);
            btnEdit.TabIndex = 3;
            btnEdit.Text = "+ Modifica un cliente";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.InactiveCaption;
            pictureBox2.Image = InsuranceCustomerManager.GUI.Properties.Resources.asslogo2_removebg_preview;
            pictureBox2.Location = new Point(28, 192);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(167, 118);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.InactiveCaption;
            label1.Font = new Font("Sylfaen", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(56, 7);
            label1.Name = "label1";
            label1.Size = new Size(102, 42);
            label1.TabIndex = 5;
            label1.Text = "Menù";
            // 
            // dgvCustomers
            // 
            dgvCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomers.Location = new Point(240, 12);
            dgvCustomers.Name = "dgvCustomers";
            dgvCustomers.Size = new Size(448, 314);
            dgvCustomers.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(dgvCustomers);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(btnEdit);
            Controls.Add(btnDel);
            Controls.Add(btnAdd);
            Controls.Add(pictureBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Orfelo assicurazioni";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btnAdd;
        private Button btnDel;
        private Button btnEdit;
        private PictureBox pictureBox2;
        private Label label1;
        private DataGridView dgvCustomers;
    }
}
