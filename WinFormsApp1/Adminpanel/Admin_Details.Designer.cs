namespace WinFormsApp1
{
    partial class Admin_Details
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_Details));
            userPic = new PictureBox();
            openFileDialog1 = new OpenFileDialog();
            browse = new Button();
            button1 = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label3 = new Label();
            textBox4 = new TextBox();
            label4 = new Label();
            edit = new Button();
            ((System.ComponentModel.ISupportInitialize)userPic).BeginInit();
            SuspendLayout();
            // 
            // userPic
            // 
            userPic.BackgroundImageLayout = ImageLayout.Zoom;
            userPic.Cursor = Cursors.Hand;
            userPic.Image = (Image)resources.GetObject("userPic.Image");
            userPic.Location = new Point(155, 33);
            userPic.Name = "userPic";
            userPic.Size = new Size(150, 129);
            userPic.TabIndex = 0;
            userPic.TabStop = false;
            userPic.WaitOnLoad = true;
            userPic.Click += userPic_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // browse
            // 
            browse.Location = new Point(178, 171);
            browse.Name = "browse";
            browse.Size = new Size(92, 34);
            browse.TabIndex = 1;
            browse.Text = "browse";
            browse.UseVisualStyleBackColor = true;
            browse.Click += browse_Click;
            // 
            // button1
            // 
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(57, 34);
            button1.TabIndex = 2;
            button1.Text = "back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(121, 208);
            label1.Name = "label1";
            label1.Size = new Size(97, 32);
            label1.TabIndex = 3;
            label1.Text = "Name : ";
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(208, 208);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(150, 32);
            textBox1.TabIndex = 4;
            textBox1.Text = "Demo";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(128, 243);
            label2.Name = "label2";
            label2.Size = new Size(90, 32);
            label2.TabIndex = 5;
            label2.Text = "Email : ";
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(208, 243);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(258, 32);
            textBox2.TabIndex = 6;
            textBox2.Text = "Demo";
            // 
            // textBox3
            // 
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(208, 281);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(258, 32);
            textBox3.TabIndex = 8;
            textBox3.Text = "Demo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(78, 281);
            label3.Name = "label3";
            label3.Size = new Size(140, 32);
            label3.TabIndex = 7;
            label3.Text = "Username : ";
            // 
            // textBox4
            // 
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox4.Location = new Point(208, 319);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(258, 32);
            textBox4.TabIndex = 10;
            textBox4.Text = "Demo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(85, 316);
            label4.Name = "label4";
            label4.Size = new Size(133, 32);
            label4.TabIndex = 9;
            label4.Text = "Admin ID : ";
            // 
            // edit
            // 
            edit.Location = new Point(178, 380);
            edit.Name = "edit";
            edit.Size = new Size(77, 34);
            edit.TabIndex = 11;
            edit.Text = "Edit";
            edit.UseVisualStyleBackColor = true;
            edit.Click += edit_Click;
            // 
            // Admin_Details
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(478, 444);
            Controls.Add(edit);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(browse);
            Controls.Add(userPic);
            Name = "Admin_Details";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin_Details";
            ((System.ComponentModel.ISupportInitialize)userPic).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox userPic;
        private OpenFileDialog openFileDialog1;
        private Button browse;
        private Button button1;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox4;
        private Label label4;
        private Button edit;
    }
}