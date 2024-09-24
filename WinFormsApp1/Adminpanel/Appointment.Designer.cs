namespace WinFormsApp1.Adminpanel
{
    partial class Appointment
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
            button2 = new Button();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            comboBox1 = new ComboBox();
            label3 = new Label();
            button3 = new Button();
            label4 = new Label();
            comboBox2 = new ComboBox();
            label5 = new Label();
            comboBox3 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Cursor = Cursors.Hand;
            button2.Location = new Point(29, 28);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 26;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(441, 101);
            label2.Name = "label2";
            label2.Size = new Size(228, 38);
            label2.TabIndex = 23;
            label2.Text = "Appointment List";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonFace;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(29, 260);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(994, 417);
            dataGridView1.TabIndex = 22;
            // 
            // label1
            // 
            label1.BackColor = Color.DeepSkyBlue;
            label1.Font = new Font("Bahnschrift SemiCondensed", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 0, 192);
            label1.Location = new Point(441, 17);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(238, 61);
            label1.TabIndex = 21;
            label1.Text = "Dream Hospital";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(29, 212);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(182, 33);
            comboBox1.TabIndex = 27;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 184);
            label3.Name = "label3";
            label3.Size = new Size(181, 25);
            label3.TabIndex = 28;
            label3.Text = "Patient appointments";
            // 
            // button3
            // 
            button3.Cursor = Cursors.Hand;
            button3.Location = new Point(451, 683);
            button3.Name = "button3";
            button3.Size = new Size(112, 34);
            button3.TabIndex = 32;
            button3.Text = "Print";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(441, 184);
            label4.Name = "label4";
            label4.Size = new Size(183, 25);
            label4.TabIndex = 31;
            label4.Text = "Doctor appointments";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(442, 212);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(182, 33);
            comboBox2.TabIndex = 30;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(782, 184);
            label5.Name = "label5";
            label5.Size = new Size(241, 25);
            label5.TabIndex = 34;
            label5.Text = "Datewise Total appointments";
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(782, 212);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(241, 33);
            comboBox3.TabIndex = 33;
            // 
            // Appointment
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1085, 726);
            Controls.Add(label5);
            Controls.Add(comboBox3);
            Controls.Add(button3);
            Controls.Add(label4);
            Controls.Add(comboBox2);
            Controls.Add(label3);
            Controls.Add(comboBox1);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "Appointment";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Appointment";
            Load += Appointment_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Label label2;
        public DataGridView dataGridView1;
        private Label label1;
        private ComboBox comboBox1;
        private Label label3;
        private Button button3;
        private Label label4;
        private ComboBox comboBox2;
        private Label label5;
        private ComboBox comboBox3;
    }
}