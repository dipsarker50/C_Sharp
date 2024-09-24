namespace WinFormsApp1.Patients
{
    partial class MakeAppointment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MakeAppointment));
            label1 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            button1 = new Button();
            textBox1 = new TextBox();
            button2 = new Button();
            comboBoxSpecialty = new ComboBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.DeepSkyBlue;
            label1.Font = new Font("Bahnschrift SemiCondensed", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 0, 192);
            label1.Location = new Point(257, 9);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(306, 58);
            label1.TabIndex = 5;
            label1.Text = "Dream Hospital";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Location = new Point(12, 156);
            flowLayoutPanel1.Margin = new Padding(10);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(10);
            flowLayoutPanel1.Size = new Size(943, 434);
            flowLayoutPanel1.TabIndex = 6;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.Location = new Point(12, 20);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 0;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(639, 113);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Search by Doctor Name";
            textBox1.Size = new Size(191, 31);
            textBox1.TabIndex = 7;
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button2
            // 
            button2.BackColor = Color.RoyalBlue;
            button2.Cursor = Cursors.Hand;
            button2.Location = new Point(843, 112);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 8;
            button2.Text = "Search";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // comboBoxSpecialty
            // 
            comboBoxSpecialty.FormattingEnabled = true;
            comboBoxSpecialty.Location = new Point(12, 113);
            comboBoxSpecialty.Name = "comboBoxSpecialty";
            comboBoxSpecialty.Size = new Size(128, 33);
            comboBoxSpecialty.TabIndex = 9;
            comboBoxSpecialty.SelectedIndexChanged += comboBoxSpecialty_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.MenuHighlight;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(331, 105);
            label2.Name = "label2";
            label2.Size = new Size(172, 38);
            label2.TabIndex = 10;
            label2.Text = "Doctor Lists";
            // 
            // MakeAppointment
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(984, 622);
            Controls.Add(label2);
            Controls.Add(comboBoxSpecialty);
            Controls.Add(button2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(label1);
            Name = "MakeAppointment";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MakeAppointment";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button button1;
        public TextBox textBox1;
        private Button button2;
        private ComboBox comboBoxSpecialty;
        private Label label2;
    }
}