using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Database;

namespace WinFormsApp1.Patients
{
    public partial class DoctorCard : UserControl
    {
        private string PatientId;
        private string DoctorId;
        DatabaseManager database;

        public DoctorCard(string name, string speciality, string userImage, string PatientId)
        {
            InitializeComponent();
            database = new DatabaseManager();
            label6.Text = name;
            label5.Text = speciality;
            this.PatientId = PatientId;
            DoctorId = database.GetDoctorIdByName(name);

            // Set user picture

            userPic.Image = Image.FromFile(userImage); ;

            // Button click event for "View Details"
            //button5.Click += button5_Click_1;
        }



        private void button5_Click_1(object sender, EventArgs e)
        {

            new AppointmentForm(PatientId, DoctorId).Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
