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
    public partial class Patient_Details : Form
    {
        DatabaseManager database;
        string patientId;
        public Patient_Details(string patientId)
        {
            InitializeComponent();
            database = new DatabaseManager();
            this.patientId = patientId;
            LoadPatientDetails();
            this.FormClosing += new FormClosingEventHandler(MainForm_FormClosing);

        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void LoadPatientDetails()
        {
            Patient patient = database.GetPatientById(patientId);

            if (patient != null)
            {
                textBox1.Text = patient.FullName;
                textBox2.Text = patient.Age.ToString();
                textBox3.Text = patient.PhoneNumber;
                textBox4.Text = patientId.ToString();
                textBox5.Text = patient.Address;
                textBox6.Text = patient.MedicalCondition;

            }
            else
            {
                MessageBox.Show("Patient not found.");
            }
        }
        private void Patient_Details_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Patients_Dashboard(patientId).Show();
            this.Hide();    
        }
    }

    public class Patient
    {
        public string FullName { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public string MedicalCondition { get; set; }
        public string PhoneNumber { get; set; }
    }

}
