using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1.Patients
{
    partial class Patients_Dashboard
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
            ComponentResourceManager resources = new ComponentResourceManager(typeof(Patients_Dashboard));
            label1 = new Label();
            button4 = new Button();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label3 = new Label();
            label4 = new Label();
            button8 = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            button5 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.DeepSkyBlue;
            label1.Font = new Font("Bahnschrift SemiCondensed", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 0, 192);
            label1.Location = new Point(481, 24);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(306, 58);
            label1.TabIndex = 4;
            label1.Text = "Dream Hospital";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // button4
            // 
            button4.Cursor = Cursors.Hand;
            button4.ForeColor = SystemColors.ActiveCaptionText;
            button4.Location = new Point(1132, 24);
            button4.Name = "button4";
            button4.Size = new Size(82, 34);
            button4.TabIndex = 11;
            button4.Text = "Logout";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(62, 194);
            label2.Name = "label2";
            label2.Size = new Size(0, 25);
            label2.TabIndex = 13;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(128, 128, 255);
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(22, 269);
            button1.Name = "button1";
            button1.Size = new Size(209, 96);
            button1.TabIndex = 14;
            button1.Text = "Book Appointment";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaption;
            button2.Cursor = Cursors.Hand;
            button2.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ActiveCaptionText;
            button2.Location = new Point(22, 123);
            button2.Name = "button2";
            button2.Size = new Size(209, 96);
            button2.TabIndex = 15;
            button2.Text = "Profile";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.WindowFrame;
            button3.Cursor = Cursors.Hand;
            button3.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.ActiveCaptionText;
            button3.Location = new Point(22, 438);
            button3.Name = "button3";
            button3.Size = new Size(209, 96);
            button3.TabIndex = 16;
            button3.Text = "Contact Us";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(267, 123);
            label3.Name = "label3";
            label3.Size = new Size(333, 30);
            label3.TabIndex = 17;
            label3.Text = "Welcome back, [Patient Name]";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(267, 218);
            label4.Name = "label4";
            label4.Size = new Size(274, 30);
            label4.TabIndex = 19;
            label4.Text = "Upcoming Appointments";
            // 
            // button8
            // 
            button8.BackgroundImage = (Image)resources.GetObject("button8.BackgroundImage");
            button8.Cursor = Cursors.Hand;
            button8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button8.ForeColor = SystemColors.ButtonFace;
            button8.Location = new Point(961, 211);
            button8.Name = "button8";
            button8.Size = new Size(214, 37);
            button8.TabIndex = 27;
            button8.Text = "All Appointments";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BackgroundImage = (Image)resources.GetObject("flowLayoutPanel1.BackgroundImage");
            flowLayoutPanel1.Location = new Point(267, 269);
            flowLayoutPanel1.Margin = new Padding(10);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(10);
            flowLayoutPanel1.Size = new Size(908, 341);
            flowLayoutPanel1.TabIndex = 0;
            flowLayoutPanel1.WrapContents = false;
            // 
            // button5
            // 
            button5.BackColor = Color.Red;
            button5.ForeColor = SystemColors.ActiveCaptionText;
            button5.Location = new Point(62, 550);
            button5.Margin = new Padding(2);
            button5.Name = "button5";
            button5.Size = new Size(115, 60);
            button5.TabIndex = 28;
            button5.Text = "Exit";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // Patients_Dashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1238, 622);
            Controls.Add(button5);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(button8);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(button4);
            Controls.Add(label1);
            ForeColor = SystemColors.ButtonFace;
            Name = "Patients_Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Patients_Dashboard";
            Load += Patients_Dashboard_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button4;
        private Label label2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label3;
        private Label label4;
        private Button button8;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button button5;
    }
}