﻿namespace InsuranceCustomerManager.GUI
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            btnAdd = new Button();
            btnDel = new Button();
            btnEdit = new Button();
            picLogo = new PictureBox();
            dgvCustomers = new DataGridView();
            panelMenu = new Panel();
            lblTitle = new Label();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).BeginInit();
            panelMenu.SuspendLayout();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Sylfaen", 9F, FontStyle.Bold);
            btnAdd.Location = new Point(11, 87);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(235, 36);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Aggiungi un nuovo cliente";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDel
            // 
            btnDel.Font = new Font("Sylfaen", 9F, FontStyle.Bold);
            btnDel.Location = new Point(13, 172);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(235, 36);
            btnDel.TabIndex = 2;
            btnDel.Text = "Rimuovi un cliente";
            btnDel.UseVisualStyleBackColor = true;
            btnDel.Click += btnDel_Click;
            // 
            // btnEdit
            // 
            btnEdit.Font = new Font("Sylfaen", 9F, FontStyle.Bold);
            btnEdit.Location = new Point(13, 130);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(235, 36);
            btnEdit.TabIndex = 3;
            btnEdit.Text = "Modifica un cliente";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // picLogo
            // 
            picLogo.BackColor = SystemColors.InactiveCaption;
            picLogo.Image = Properties.Resources.asslogo2_removebg_preview;
            picLogo.Location = new Point(32, 256);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(191, 157);
            picLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            picLogo.TabIndex = 4;
            picLogo.TabStop = false;
            // 
            // dgvCustomers
            // 
            dgvCustomers.AllowUserToAddRows = false;
            dgvCustomers.AllowUserToDeleteRows = false;
            dgvCustomers.AllowUserToResizeColumns = false;
            dgvCustomers.AllowUserToResizeRows = false;
            dgvCustomers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvCustomers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomers.Location = new Point(265, -1);
            dgvCustomers.Margin = new Padding(3, 4, 3, 4);
            dgvCustomers.MultiSelect = false;
            dgvCustomers.Name = "dgvCustomers";
            dgvCustomers.ReadOnly = true;
            dgvCustomers.RowHeadersWidth = 51;
            dgvCustomers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCustomers.Size = new Size(573, 452);
            dgvCustomers.TabIndex = 0;
            dgvCustomers.TabStop = false;
            // 
            // panelMenu
            // 
            panelMenu.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelMenu.BackColor = SystemColors.InactiveCaption;
            panelMenu.Controls.Add(btnDel);
            panelMenu.Controls.Add(btnEdit);
            panelMenu.Location = new Point(-2, -1);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(343, 452);
            panelMenu.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = SystemColors.InactiveCaption;
            lblTitle.Font = new Font("Sylfaen", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(64, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(125, 52);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Menù";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(837, 451);
            Controls.Add(dgvCustomers);
            Controls.Add(lblTitle);
            Controls.Add(picLogo);
            Controls.Add(btnAdd);
            Controls.Add(panelMenu);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(818, 498);
            Name = "MainForm";
            Text = "Orfelo assicurazioni";
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).EndInit();
            panelMenu.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnAdd;
        private Button btnDel;
        private Button btnEdit;
        private PictureBox picLogo;
        private DataGridView dgvCustomers;
        private Panel panelMenu;
        private Label lblTitle;
    }
}
