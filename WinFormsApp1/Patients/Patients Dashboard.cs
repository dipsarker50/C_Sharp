using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Database;

namespace WinFormsApp1.Patients
{
    public partial class Patients_Dashboard : Form
    {
        DatabaseManager database;
        string PatientId;
        string patientName;
        public Patients_Dashboard(string patientId)
        {

            database = new DatabaseManager();
            InitializeComponent();
            PatientId = patientId;
            Debug.WriteLine("ID in Signin: " + PatientId);
            LoadAppointments();
            label3.Text = $"Welcome back, {database.GetPatientNameById(PatientId)}";
            this.FormClosing += new FormClosingEventHandler(MainForm_FormClosing);

        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new MakeAppointment(PatientId).Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }




        private void LoadAppointments()
        {
            int id = Int32.Parse(PatientId);

            database.UpdatePastAppointmentsToDone();

            List<AppointmentInfo> appointments = database.GetUpcomingAppointments(id, 3);

            foreach (var appointment in appointments)
            {
                // Create a new card for each appointment
                Card card = new Card(appointment.DoctorName, appointment.Specialty, appointment.AppointmentTime.ToString(), database.GetDoctorImagePath(appointment.DoctorName));
                flowLayoutPanel1.Controls.Add(card);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            new SignIn().Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            new AllAppointment(PatientId).Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Patient_Details(PatientId).Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string email = "support@example.com";
            string message = $"For any data changes or support, please email us at: {email}";
            string caption = "Support";
            MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you wish to exit?", "Warning", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {

                Application.Exit();

            }
        }

        private void Patients_Dashboard_Load(object sender, EventArgs e)
        {

        }
    }

    public class AppointmentInfo
    {
        public int AppointmentId { get; set; }
        public string DoctorName { get; set; }
        public string Specialty { get; set; }
        public DateTime AppointmentTime { get; set; }

        public string DoctorImagePath { get; set; }
    }

}
