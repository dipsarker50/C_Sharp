using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Database;

namespace WinFormsApp1.Patients
{
    public partial class MakeAppointment : Form
    {
        DatabaseManager database;
        private string patientId;
        public MakeAppointment(string patientId)
        {

            InitializeComponent();
            database = new DatabaseManager();
            InitializeComboBox();
            this.patientId = patientId;
            LoadDoctorsFromDatabase();
            this.FormClosing += new FormClosingEventHandler(MainForm_FormClosing);

        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }



        private void LoadDoctorsFromDatabase()
        {

            List<Doctor> doctors = database.GetAllDoctors();
            LoadDoctorCards(doctors);
        }

        private void LoadDoctorCards(List<Doctor> doctors)
        {
            flowLayoutPanel1.Controls.Clear();

            foreach (var doctor in doctors)
            {
                DoctorCard card = new DoctorCard(doctor.DoctorName, doctor.Specialty, doctor.DoctorImagePath, patientId);
                flowLayoutPanel1.Controls.Add(card);
            }
        }


        private void SearchDoctors()
        {
            string searchTerm = textBox1.Text;
            if (searchTerm != null)
            {
                List<Doctor> allDoctors = database.GetAllDoctors();
                List<Doctor> filteredDoctors = allDoctors
                    .Where(d => d.DoctorName.IndexOf(searchTerm, StringComparison.OrdinalIgnoreCase) >= 0)
                    .ToList();
                LoadDoctorCards(filteredDoctors);
            }
            else
            {
                MessageBox.Show("No data Found.");

            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            new Patients_Dashboard(patientId).Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SearchDoctors();
        }

        private void InitializeComboBox()
        {
            comboBoxSpecialty.Items.Clear();
            comboBoxSpecialty.Items.Add("Filter by");

            var specialties = database.GetAllSpecialties();
            comboBoxSpecialty.Items.AddRange(specialties.ToArray());

            comboBoxSpecialty.SelectedIndex = 0;
        }

        private void comboBoxSpecialty_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxSpecialty.SelectedIndex > 0) // Ignore default "Filter by"
            {
                string selectedSpecialty = comboBoxSpecialty.SelectedItem.ToString();
                List<Doctor> filteredDoctors = database.GetDoctorsBySpecialty(selectedSpecialty);
                LoadDoctorCards(filteredDoctors);
            }
            else
            {
                LoadDoctorsFromDatabase(); // Load all doctors if "Filter by" is selected
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }

    public class Doctor
    {
        public int AppointmentId { get; set; }
        public string DoctorName { get; set; }
        public string Specialty { get; set; }
        public string DoctorImagePath { get; set; }

        public string patientId {  get; set; }  
    }
}
