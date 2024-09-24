using System;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormsApp1.Patients
{
    public partial class Card : UserControl
    {
        public Card(string name, string speciality, string dateTime, string userImage)
        {
            InitializeComponent();

            // Set label text
            label6.Text = name;
            label5.Text = speciality;
            label7.Text = dateTime;

            // Set user picture

            userPic.Image = Image.FromFile(userImage); ;

            // Button click event for "View Details"
            //button5.Click += Button5_Click;
        }

        // Event handler for the "View Details" button
        private void Button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"{label6.Text}'s details will be shown.");
        }
    }
}
