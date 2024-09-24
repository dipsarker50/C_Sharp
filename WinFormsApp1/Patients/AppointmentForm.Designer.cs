using System;
using System.Windows.Forms;


namespace WinFormsApp1.Patients
{
    partial class AppointmentForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dateTimePicker = new DateTimePicker();
            comboBoxTime = new ComboBox();
            buttonBook = new Button();
            labelDate = new Label();
            labelTime = new Label();
            SuspendLayout();
            // 
            // dateTimePicker
            // 
            dateTimePicker.Format = DateTimePickerFormat.Short;
            dateTimePicker.Location = new Point(55, 64);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(366, 31);
            dateTimePicker.TabIndex = 0;
            // 
            // comboBoxTime
            // 
            comboBoxTime.BackColor = SystemColors.ControlLightLight;
            comboBoxTime.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTime.FormattingEnabled = true;
            comboBoxTime.Location = new Point(55, 150);
            comboBoxTime.Name = "comboBoxTime";
            comboBoxTime.Size = new Size(366, 33);
            comboBoxTime.TabIndex = 1;
            comboBoxTime.SelectedIndexChanged += comboBoxTime_SelectedIndexChanged;
            // 
            // buttonBook
            // 
            buttonBook.BackColor = Color.MidnightBlue;
            buttonBook.Cursor = Cursors.Hand;
            buttonBook.ForeColor = Color.White;
            buttonBook.Location = new Point(191, 209);
            buttonBook.Name = "buttonBook";
            buttonBook.Size = new Size(100, 40);
            buttonBook.TabIndex = 2;
            buttonBook.Text = "Book";
            buttonBook.UseVisualStyleBackColor = false;
            buttonBook.Click += buttonConfirm_Click;
            // 
            // labelDate
            // 
            labelDate.AutoSize = true;
            labelDate.BackColor = Color.RoyalBlue;
            labelDate.ForeColor = SystemColors.ButtonFace;
            labelDate.Location = new Point(55, 36);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(53, 25);
            labelDate.TabIndex = 3;
            labelDate.Text = "Date:";
            // 
            // labelTime
            // 
            labelTime.AutoSize = true;
            labelTime.ForeColor = SystemColors.ButtonFace;
            labelTime.Location = new Point(55, 122);
            labelTime.Name = "labelTime";
            labelTime.Size = new Size(54, 25);
            labelTime.TabIndex = 4;
            labelTime.Text = "Time:";
            labelTime.Click += labelTime_Click;
            // 
            // AppointmentForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RoyalBlue;
            ClientSize = new Size(499, 271);
            Controls.Add(labelTime);
            Controls.Add(labelDate);
            Controls.Add(buttonBook);
            Controls.Add(comboBoxTime);
            Controls.Add(dateTimePicker);
            Name = "AppointmentForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Book Appointment";
            Load += AppointmentForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.ComboBox comboBoxTime;
        private System.Windows.Forms.Button buttonBook;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelTime;
    }
}
