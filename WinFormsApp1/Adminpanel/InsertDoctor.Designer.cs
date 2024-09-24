namespace WinFormsApp1
{
    partial class InsertDoctor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InsertDoctor));
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            openFileDialog1 = new OpenFileDialog();
            browse = new Button();
            userPic = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)userPic).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(0, 192, 192);
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(266, 43);
            label1.Name = "label1";
            label1.Size = new Size(152, 32);
            label1.TabIndex = 0;
            label1.Text = "Insert Doctor";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(133, 101);
            label2.Name = "label2";
            label2.Size = new Size(90, 32);
            label2.TabIndex = 1;
            label2.Text = "Name :";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(229, 104);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Doctor Name";
            textBox1.Size = new Size(274, 37);
            textBox1.TabIndex = 2;
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(229, 179);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Doctor Speciality";
            textBox2.Size = new Size(274, 37);
            textBox2.TabIndex = 4;
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(96, 180);
            label3.Name = "label3";
            label3.Size = new Size(127, 32);
            label3.TabIndex = 3;
            label3.Text = "Speciality :";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(229, 252);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Doctor Phone Number";
            textBox3.Size = new Size(274, 37);
            textBox3.TabIndex = 6;
            textBox3.TextAlign = HorizontalAlignment.Center;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(129, 252);
            label4.Name = "label4";
            label4.Size = new Size(94, 32);
            label4.TabIndex = 5;
            label4.Text = "Phone :";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // browse
            // 
            browse.Location = new Point(266, 494);
            browse.Name = "browse";
            browse.Size = new Size(150, 34);
            browse.TabIndex = 11;
            browse.Text = "Set and Save";
            browse.UseVisualStyleBackColor = true;
            browse.Click += browse_Click;
            // 
            // userPic
            // 
            userPic.BackgroundImageLayout = ImageLayout.Zoom;
            userPic.Cursor = Cursors.Hand;
            userPic.Image = (Image)resources.GetObject("userPic.Image");
            userPic.Location = new Point(266, 323);
            userPic.Name = "userPic";
            userPic.Size = new Size(150, 129);
            userPic.TabIndex = 10;
            userPic.TabStop = false;
            userPic.WaitOnLoad = true;
            userPic.Click += userPic_Click;
            // 
            // InsertDoctor
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(644, 571);
            Controls.Add(browse);
            Controls.Add(userPic);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "InsertDoctor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "InsertDoctor";
            Load += InsertDoctor_Load;
            ((System.ComponentModel.ISupportInitialize)userPic).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox3;
        private Label label4;
        private OpenFileDialog openFileDialog1;
        private Button browse;
        private PictureBox userPic;
    }
}