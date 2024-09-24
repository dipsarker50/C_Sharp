namespace WinFormsApp1.Adminpanel
{
    partial class InsertAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InsertAdmin));
            textBox2 = new TextBox();
            label3 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            openFileDialog1 = new OpenFileDialog();
            browse = new Button();
            userPic = new PictureBox();
            textBox4 = new TextBox();
            label5 = new Label();
            textBox5 = new TextBox();
            label6 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)userPic).BeginInit();
            SuspendLayout();
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(222, 179);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Admin Email";
            textBox2.Size = new Size(274, 37);
            textBox2.TabIndex = 16;
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(126, 184);
            label3.Name = "label3";
            label3.Size = new Size(83, 32);
            label3.TabIndex = 15;
            label3.Text = "Email :";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(222, 104);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Admin Name";
            textBox1.Size = new Size(274, 37);
            textBox1.TabIndex = 14;
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(126, 101);
            label2.Name = "label2";
            label2.Size = new Size(90, 32);
            label2.TabIndex = 13;
            label2.Text = "Name :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(0, 192, 192);
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(259, 43);
            label1.Name = "label1";
            label1.Size = new Size(150, 32);
            label1.TabIndex = 12;
            label1.Text = "Insert Admin";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // browse
            // 
            browse.Location = new Point(256, 605);
            browse.Name = "browse";
            browse.Size = new Size(150, 34);
            browse.TabIndex = 20;
            browse.Text = "Insert Admin";
            browse.UseVisualStyleBackColor = true;
            browse.Click += buttonAddAdmin_Click;
            // 
            // userPic
            // 
            userPic.BackgroundImageLayout = ImageLayout.Zoom;
            userPic.Cursor = Cursors.Hand;
            userPic.Image = (Image)resources.GetObject("userPic.Image");
            userPic.Location = new Point(256, 401);
            userPic.Name = "userPic";
            userPic.Size = new Size(150, 129);
            userPic.TabIndex = 19;
            userPic.TabStop = false;
            userPic.WaitOnLoad = true;
            userPic.Click += userPic_Click;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox4.Location = new Point(222, 338);
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "Admin Password";
            textBox4.Size = new Size(274, 37);
            textBox4.TabIndex = 24;
            textBox4.TextAlign = HorizontalAlignment.Center;
            textBox4.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(93, 338);
            label5.Name = "label5";
            label5.Size = new Size(123, 32);
            label5.TabIndex = 23;
            label5.Text = "Password :";
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox5.Location = new Point(222, 265);
            textBox5.Name = "textBox5";
            textBox5.PlaceholderText = "Admin Username";
            textBox5.Size = new Size(274, 37);
            textBox5.TabIndex = 22;
            textBox5.TextAlign = HorizontalAlignment.Center;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(83, 265);
            label6.Name = "label6";
            label6.Size = new Size(133, 32);
            label6.TabIndex = 21;
            label6.Text = "Username :";
            // 
            // button1
            // 
            button1.Location = new Point(273, 536);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 25;
            button1.Text = "Browse";
            button1.UseVisualStyleBackColor = true;
            button1.Click += browse_Click;
            // 
            // InsertAdmin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoScrollMargin = new Size(0, 300);
            ClientSize = new Size(644, 571);
            Controls.Add(button1);
            Controls.Add(textBox4);
            Controls.Add(label5);
            Controls.Add(textBox5);
            Controls.Add(label6);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(browse);
            Controls.Add(userPic);
            Name = "InsertAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "InsertAdmin";
            Load += InsertAdmin_Load;
            ((System.ComponentModel.ISupportInitialize)userPic).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox1;
        private Label label2;
        private Label label1;
        private OpenFileDialog openFileDialog1;
        private Button browse;
        private PictureBox userPic;
        private TextBox textBox4;
        private Label label5;
        private TextBox textBox5;
        private Label label6;
        private Button button1;
    }
}