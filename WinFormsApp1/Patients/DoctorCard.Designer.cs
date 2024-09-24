namespace WinFormsApp1.Patients
{
    partial class DoctorCard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoctorCard));
            panel1 = new Panel();
            button5 = new Button();
            label5 = new Label();
            label6 = new Label();
            userPic = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)userPic).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.RoyalBlue;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(button5);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(userPic);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(276, 302);
            panel1.TabIndex = 3;
            panel1.Paint += panel1_Paint;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(0, 0, 192);
            button5.Cursor = Cursors.Hand;
            button5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.ForeColor = SystemColors.ButtonHighlight;
            button5.Location = new Point(47, 230);
            button5.Name = "button5";
            button5.Size = new Size(177, 49);
            button5.TabIndex = 25;
            button5.Text = "Book Appointment";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click_1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(103, 185);
            label5.Name = "label5";
            label5.Size = new Size(86, 25);
            label5.TabIndex = 23;
            label5.Text = "Speciality";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Trebuchet MS", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(0, 0, 192);
            label6.Location = new Point(93, 162);
            label6.Name = "label6";
            label6.Size = new Size(152, 23);
            label6.TabIndex = 22;
            label6.Text = "Demo Name User";
            // 
            // userPic
            // 
            userPic.BackgroundImageLayout = ImageLayout.Zoom;
            userPic.Cursor = Cursors.Hand;
            userPic.Image = (Image)resources.GetObject("userPic.Image");
            userPic.Location = new Point(68, 17);
            userPic.Name = "userPic";
            userPic.Size = new Size(141, 121);
            userPic.TabIndex = 20;
            userPic.TabStop = false;
            userPic.WaitOnLoad = true;
            // 
            // DoctorCard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Margin = new Padding(10);
            Name = "DoctorCard";
            Padding = new Padding(10);
            Size = new Size(276, 302);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)userPic).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button5;
        private Label label5;
        private Label label6;
        private PictureBox userPic;
    }
}
