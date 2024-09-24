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
    public partial class AllAppointment : Form
    {
        DatabaseManager database;
        string paitentId;
        public AllAppointment(string patientId)
        {
            InitializeComponent();
            database = new DatabaseManager();
            this.paitentId = patientId;
            LoadTable(patientId);
            this.FormClosing += new FormClosingEventHandler(MainForm_FormClosing);

        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void LoadTable(string patientId)
        {

            DataTable appointmentsTable = database.GetPatientAppointmentsByID(patientId);
            
            var upcomingAppointments = appointmentsTable.Select("AppointmentStatus <> 'Canceled'").CopyToDataTable();

            if (appointmentsTable.Rows.Count == 0)
            {
                MessageBox.Show("No appointments found.");
                return;
            }
            appointmentsTable.Columns.Add("Action", typeof(string));
            foreach (DataRow row in appointmentsTable.Rows)
            {

                if (row["AppointmentStatus"].ToString() == "Upcoming")
                {
                    row["Action"] = "x";
                }
                else
                {
                    row["Action"] = DBNull.Value;
                }
            }

            dataGridView1.DataSource = appointmentsTable;

            dataGridView1.Columns["AppointmentID"].HeaderText = "ID";
            dataGridView1.Columns["DoctorName"].HeaderText = "Doctor Name";
            dataGridView1.Columns["AppointmentStatus"].HeaderText = "Status";
            dataGridView1.Columns["AppointmentTime"].HeaderText = "Appointment Time";
            dataGridView1.Columns["Action"].HeaderText = "Action";


            dataGridView1.Columns["AppointmentID"].ReadOnly = true;
            dataGridView1.Columns["DoctorName"].ReadOnly = true;
            dataGridView1.Columns["AppointmentStatus"].ReadOnly = true;
            dataGridView1.Columns["AppointmentTime"].ReadOnly = true;
            dataGridView1.Columns["Action"].ReadOnly = true;


            dataGridView1.Columns["AppointmentID"].Width = 100;
            dataGridView1.Columns["DoctorName"].Width = 300;
            dataGridView1.Columns["AppointmentStatus"].Width = 150;
            dataGridView1.Columns["AppointmentTime"].Width = 300;
            dataGridView1.Columns["Action"].Width = 150;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.CellClick += DataGridView1_CellClick;
        }



        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridView1.Columns["Action"].Index)
            {

                string appointmentStatus = dataGridView1.Rows[e.RowIndex].Cells["AppointmentStatus"].Value.ToString();

                if (appointmentStatus == "Upcoming")
                {
                    int appointmentId = (int)dataGridView1.Rows[e.RowIndex].Cells["AppointmentID"].Value;

                    var result = MessageBox.Show("Are you sure you want to cancel this appointment?", "Confirm Cancellation", MessageBoxButtons.YesNo);

                    if (result == DialogResult.Yes)
                    {
                        bool isCancelled = database.CancelAppointment(appointmentId);
                        if (isCancelled)
                        {
                            MessageBox.Show("Appointment cancelled successfully.");
                            LoadTable(paitentId);
                        }
                        else
                        {
                            MessageBox.Show("Failed to cancel the appointment.");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("You cannot cancel this appointment.");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Patients_Dashboard(paitentId).Show();
            this.Hide();
        }
    }
}
