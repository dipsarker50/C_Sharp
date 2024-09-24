
using System;
using System.Windows.Forms;

namespace WinFormsApp1
{
    partial class Signup        
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
            button1 = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox5 = new TextBox();
            label7 = new Label();
            label8 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label9 = new Label();
            comboBox1 = new ComboBox();
            textBox4 = new TextBox();
            label10 = new Label();
            linkLabel1 = new LinkLabel();
            button2 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 0, 192);
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(565, 1190);
            button1.Name = "button1";
            button1.Size = new Size(210, 80);
            button1.TabIndex = 1;
            button1.Text = "Sign Up";
            button1.UseVisualStyleBackColor = false;
            button1.Click += Signup_Load;
            button1.MouseDown += buttonLogin_MouseDown;
            button1.MouseUp += buttonLogin_MouseUp;
            // 
            // label1
            // 
            label1.BackColor = Color.DeepSkyBlue;
            label1.Font = new Font("Bahnschrift SemiCondensed", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 0, 192);
            label1.Location = new Point(528, 39);
            label1.Name = "label1";
            label1.Size = new Size(408, 78);
            label1.TabIndex = 3;
            label1.Text = "Dream Hospital";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(0, 0, 192);
            label2.Location = new Point(223, 242);
            label2.Name = "label2";
            label2.Size = new Size(166, 45);
            label2.TabIndex = 4;
            label2.Text = "FullName";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(0, 0, 192);
            label3.Location = new Point(316, 351);
            label3.Name = "label3";
            label3.Size = new Size(0, 45);
            label3.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(467, 234);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Enter FullName";
            textBox1.Size = new Size(594, 57);
            textBox1.TabIndex = 5;
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(467, 343);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Enter Address";
            textBox2.Size = new Size(594, 57);
            textBox2.TabIndex = 6;
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(467, 443);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Enter PhoneNumber";
            textBox3.Size = new Size(594, 57);
            textBox3.TabIndex = 7;
            textBox3.TextAlign = HorizontalAlignment.Center;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(0, 0, 192);
            label4.Location = new Point(245, 351);
            label4.Name = "label4";
            label4.Size = new Size(144, 45);
            label4.TabIndex = 9;
            label4.Text = "Address";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(0, 0, 192);
            label5.Location = new Point(144, 451);
            label5.Name = "label5";
            label5.Size = new Size(245, 45);
            label5.TabIndex = 10;
            label5.Text = "PhoneNumber";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Calibri", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(0, 0, 192);
            label6.Location = new Point(236, 907);
            label6.Name = "label6";
            label6.Size = new Size(153, 45);
            label6.TabIndex = 11;
            label6.Text = "Diseases";
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox5.Location = new Point(467, 551);
            textBox5.Name = "textBox5";
            textBox5.PlaceholderText = "Enter Password";
            textBox5.Size = new Size(594, 57);
            textBox5.TabIndex = 12;
            textBox5.TextAlign = HorizontalAlignment.Center;
            textBox5.UseSystemPasswordChar = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Calibri", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(0, 0, 192);
            label7.Location = new Point(221, 559);
            label7.Name = "label7";
            label7.Size = new Size(168, 45);
            label7.TabIndex = 13;
            label7.Text = "Password";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Calibri", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(0, 0, 192);
            label8.Location = new Point(223, 676);
            label8.Name = "label8";
            label8.Size = new Size(166, 45);
            label8.TabIndex = 14;
            label8.Text = "Birthdate";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarFont = new Font("Segoe UI Semibold", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dateTimePicker1.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker1.Location = new Point(467, 664);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(594, 57);
            dateTimePicker1.TabIndex = 15;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Calibri", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.FromArgb(0, 0, 192);
            label9.Location = new Point(254, 793);
            label9.Name = "label9";
            label9.Size = new Size(135, 45);
            label9.TabIndex = 16;
            label9.Text = "Gender";
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Default", "Male", "Female", "Others" });
            comboBox1.Location = new Point(467, 785);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(591, 58);
            comboBox1.TabIndex = 17;
            comboBox1.Text = "Default";
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox4.Location = new Point(467, 899);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "Description of Diseases";
            textBox4.ScrollBars = ScrollBars.Vertical;
            textBox4.Size = new Size(591, 100);
            textBox4.TabIndex = 18;
            textBox4.TextAlign = HorizontalAlignment.Center;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(272, 1072);
            label10.Name = "label10";
            label10.Size = new Size(435, 50);
            label10.TabIndex = 19;
            label10.Text = "Do you have an account?";
            label10.Click += label10_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabel1.Location = new Point(713, 1072);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(264, 50);
            linkLabel1.TabIndex = 20;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Then click here";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // button2
            // 
            button2.Location = new Point(1142, 1169);
            button2.Name = "button2";
            button2.Size = new Size(150, 78);
            button2.TabIndex = 21;
            button2.Text = "Exit";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Signup
            // 
            AutoScaleDimensions = new SizeF(192F, 192F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoScroll = true;
            AutoScrollMargin = new Size(0, 100);
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.DeepSkyBlue;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1411, 929);
            Controls.Add(button2);
            Controls.Add(linkLabel1);
            Controls.Add(label10);
            Controls.Add(textBox4);
            Controls.Add(comboBox1);
            Controls.Add(label9);
            Controls.Add(dateTimePicker1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(textBox5);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Signup";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SignUp Screen";
            Load += Signup_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBox5;
        private Label label7;
        private Label label8;
        private MonthCalendar monthCalendar1;
        private DateTimePicker dateTimePicker1;
        private Label label9;
        private ComboBox comboBox1;
        private TextBox textBox4;
        private Label label10;
        private LinkLabel linkLabel1;
        private Button button2;
    }
}