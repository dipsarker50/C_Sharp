using System.Xml.Linq;

namespace WinFormsApp1
{
    partial class Admin_Dashboard
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
            button1 = new Button();
            label2 = new Label();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            linkLabel1 = new LinkLabel();
            button5 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.DeepSkyBlue;
            label1.Font = new Font("Bahnschrift SemiCondensed", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 0, 192);
            label1.Location = new Point(397, 24);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(238, 61);
            label1.TabIndex = 4;
            label1.Text = "Dream Hospital";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // button1
            // 
            button1.Location = new Point(58, 251);
            button1.Name = "button1";
            button1.Size = new Size(142, 67);
            button1.TabIndex = 5;
            button1.Text = "Doctor Options";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(114, 191);
            label2.Name = "label2";
            label2.Size = new Size(0, 25);
            label2.TabIndex = 6;
            // 
            // button2
            // 
            button2.Location = new Point(428, 251);
            button2.Name = "button2";
            button2.Size = new Size(142, 67);
            button2.TabIndex = 7;
            button2.Text = "Patients Options";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(801, 251);
            button3.Name = "button3";
            button3.Size = new Size(142, 67);
            button3.TabIndex = 8;
            button3.Text = "Admin Options";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(952, 51);
            button4.Name = "button4";
            button4.Size = new Size(82, 34);
            button4.TabIndex = 9;
            button4.Text = "Logout";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(952, 24);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(108, 25);
            linkLabel1.TabIndex = 10;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "demo name";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // button5
            // 
            button5.Location = new Point(428, 391);
            button5.Name = "button5";
            button5.Size = new Size(142, 67);
            button5.TabIndex = 11;
            button5.Text = "Appointments";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // Admin_Dashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1085, 726);
            Controls.Add(button5);
            Controls.Add(linkLabel1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Admin_Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin_Dashboard";
            Load += Admin_Dashboard_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Label label2;
        private Button button2;
        private Button button3;
        private Button button4;
        private LinkLabel linkLabel1;
        private Button button5;
    }
}