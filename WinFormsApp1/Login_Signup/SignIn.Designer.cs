
using System;
using System.Windows.Forms;

namespace WinFormsApp1
{
    partial class SignIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignIn));
            button1 = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            panel1 = new Panel();
            button2 = new Button();
            label4 = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            linkLabel1 = new LinkLabel();
            label5 = new Label();
           // linkLabel2 = new LinkLabel();
            radioButton1 = new RadioButton();
           // linkLabel1.setVisible (false);
            radioButton2 = new RadioButton();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 0, 192);
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(181, 511);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(162, 62);
            button1.TabIndex = 1;
            button1.Text = "Sign In";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            button1.MouseDown += buttonLogin_MouseDown;
            button1.MouseUp += buttonLogin_MouseUp;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSlateBlue;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(button2);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(496, 2);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(588, 726);
            panel1.TabIndex = 2;
            // 
            // button2
            // 
            button2.Location = new Point(397, 578);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(115, 60);
            button2.TabIndex = 8;
            button2.Text = "Exit";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(182, 149);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(0, 25);
            label4.TabIndex = 7;
            // 
            // label1
            // 
            label1.BackColor = Color.DeepSkyBlue;
            label1.Font = new Font("Bahnschrift SemiCondensed", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 0, 192);
            label1.Location = new Point(110, 41);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(314, 61);
            label1.TabIndex = 3;
            label1.Text = "Dream Hospital";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(0, 0, 192);
            label2.Location = new Point(0, 214);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(190, 35);
            label2.TabIndex = 4;
            label2.Text = "Phone Number";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(0, 0, 192);
            label3.Location = new Point(58, 331);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(126, 35);
            label3.TabIndex = 4;
            label3.Text = "Password";
            label3.Click += label3_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(199, 208);
            textBox1.Margin = new Padding(2);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Enter Number";
            textBox1.Size = new Size(246, 45);
            textBox1.TabIndex = 5;
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.TextChanged += textBox1_TextChanged;
            textBox1.Enter += TextBox_Enter;
            textBox1.Leave += TextBox_Leave;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(199, 325);
            textBox2.Margin = new Padding(2);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Enter Password";
            textBox2.Size = new Size(246, 45);
            textBox2.TabIndex = 6;
            textBox2.TextAlign = HorizontalAlignment.Center;
            textBox2.UseSystemPasswordChar = true;
            textBox2.TextChanged += textBox2_TextChanged;
            textBox2.Enter += TextBox_Enter;
            textBox2.Leave += TextBox_Leave;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabel1.Location = new Point(142, 640);
            linkLabel1.Margin = new Padding(2, 0, 2, 0);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(119, 32);
            linkLabel1.TabIndex = 7;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Click here";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;

            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(9, 640);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(125, 32);
            label5.TabIndex = 8;
            label5.Text = "New user?";
            // 
            // linkLabel2
            // 
            //linkLabel2.AutoSize = true;
            //linkLabel2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            //linkLabel2.Location = new Point(76, 422);
            //linkLabel2.Margin = new Padding(2, 0, 2, 0);
            //linkLabel2.Name = "linkLabel2";
            //linkLabel2.Size = new Size(359, 32);
            //linkLabel2.TabIndex = 9;
            //linkLabel2.TabStop = true;
            //linkLabel2.Text = "Have you forget your password?";
            //linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            //// 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(164, 151);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(87, 29);
            radioButton1.TabIndex = 11;
            radioButton1.TabStop = true;
            radioButton1.Text = "admin";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(332, 147);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(92, 29);
            radioButton2.TabIndex = 12;
            radioButton2.TabStop = true;
            radioButton2.Text = "patient";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // SignIn
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DeepSkyBlue;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1085, 726);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(linkLabel2);
            Controls.Add(label5);
            Controls.Add(linkLabel1);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Margin = new Padding(2);
            Name = "SignIn";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login Screen";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label4;
        private LinkLabel linkLabel1;
        private Label label5;
        private LinkLabel linkLabel2;
        private Button button2;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
    }
}
