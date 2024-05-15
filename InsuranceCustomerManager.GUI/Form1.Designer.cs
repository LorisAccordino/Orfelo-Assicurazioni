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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.InactiveCaption;
            pictureBox1.Location = new Point(1, -2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(266, 453);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Font = new Font("Sylfaen", 9F, FontStyle.Bold);
            button1.Location = new Point(12, 87);
            button1.Name = "button1";
            button1.Size = new Size(236, 36);
            button1.TabIndex = 1;
            button1.Text = "+ Aggiungi un nuovo cliente";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Sylfaen", 9F, FontStyle.Bold);
            button2.Location = new Point(12, 129);
            button2.Name = "button2";
            button2.Size = new Size(236, 36);
            button2.TabIndex = 2;
            button2.Text = "- Rimuovi un cliente";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Sylfaen", 9F, FontStyle.Bold);
            button3.Location = new Point(12, 171);
            button3.Name = "button3";
            button3.Size = new Size(236, 36);
            button3.TabIndex = 3;
            button3.Text = "+ Modifica un cliente";
            button3.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.InactiveCaption;
            pictureBox2.Image = InsuranceCustomerManager.GUI.Properties.Resources.asslogo2_removebg_preview;
            pictureBox2.Location = new Point(32, 256);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(191, 157);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.InactiveCaption;
            label1.Font = new Font("Sylfaen", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(64, 9);
            label1.Name = "label1";
            label1.Size = new Size(125, 52);
            label1.TabIndex = 5;
            label1.Text = "Menù";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Orfelo assicurazioni";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private PictureBox pictureBox2;
        private Label label1;
    }
}
