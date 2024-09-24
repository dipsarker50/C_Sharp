namespace WinFormsApp1
{
    partial class AdminControlDoctor
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
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            btnDelete = new Button();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button4
            // 
            button4.Location = new Point(854, 650);
            button4.Name = "button4";
            button4.Size = new Size(202, 52);
            button4.TabIndex = 20;
            button4.Text = "Refresh";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click_1;
            // 
            // button3
            // 
            button3.Location = new Point(579, 650);
            button3.Name = "button3";
            button3.Size = new Size(202, 52);
            button3.TabIndex = 19;
            button3.Text = "Insert new Doctor";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click_1;
            // 
            // button2
            // 
            button2.Location = new Point(29, 28);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 18;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // button1
            // 
            button1.Location = new Point(321, 650);
            button1.Name = "button1";
            button1.Size = new Size(203, 52);
            button1.TabIndex = 17;
            button1.Text = "Edit Doctor Details";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(62, 650);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(203, 52);
            btnDelete.TabIndex = 16;
            btnDelete.Text = "Delete Doctor Details";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(487, 104);
            label2.Name = "label2";
            label2.Size = new Size(150, 38);
            label2.TabIndex = 15;
            label2.Text = "Doctor List";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonFace;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(62, 163);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(994, 470);
            dataGridView1.TabIndex = 14;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.CellValueChanged += dataGridView1_CellValueChanged;
            // 
            // label1
            // 
            label1.BackColor = Color.DeepSkyBlue;
            label1.Font = new Font("Bahnschrift SemiCondensed", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 0, 192);
            label1.Location = new Point(456, 25);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(238, 61);
            label1.TabIndex = 13;
            label1.Text = "Dream Hospital";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // AdminControlDoctor
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
            Name = "AdminControlDoctor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminControlDoctor";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button btnDelete;
        private Label label2;
        public DataGridView dataGridView1;
        private Label label1;
    }
}