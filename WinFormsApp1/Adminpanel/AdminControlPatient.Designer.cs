namespace WinFormsApp1
{
    partial class AdminControlPatient
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
            dataGridView1 = new DataGridView();
            label2 = new Label();
            btnDelete = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.DeepSkyBlue;
            label1.Font = new Font("Bahnschrift SemiCondensed", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 0, 192);
            label1.Location = new Point(439, 9);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(238, 61);
            label1.TabIndex = 5;
            label1.Text = "Dream Hospital";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonFace;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(45, 147);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(994, 470);
            dataGridView1.TabIndex = 6;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.CellValueChanged += dataGridView1_CellValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(470, 88);
            label2.Name = "label2";
            label2.Size = new Size(151, 38);
            label2.TabIndex = 7;
            label2.Text = "Patient List";
            label2.Click += label2_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(45, 634);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(203, 52);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Delete Patient Details";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // button1
            // 
            button1.Location = new Point(304, 634);
            button1.Name = "button1";
            button1.Size = new Size(203, 52);
            button1.TabIndex = 9;
            button1.Text = "Edit Patients Details";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(12, 12);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 10;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(562, 634);
            button3.Name = "button3";
            button3.Size = new Size(202, 52);
            button3.TabIndex = 11;
            button3.Text = "Insert new Patients";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(837, 634);
            button4.Name = "button4";
            button4.Size = new Size(202, 52);
            button4.TabIndex = 12;
            button4.Text = "Refresh";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // AdminControlPatient
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1085, 726);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnDelete);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "AdminControlPatient";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminControlPatient";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        public DataGridView dataGridView1;
        private Label label2;
        private Button btnDelete;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}