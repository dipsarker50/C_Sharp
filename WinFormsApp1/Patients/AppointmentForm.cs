using System;
using System.Diagnostics;
using System.Windows.Forms;
using Database;

namespace WinFormsApp1.Patients
{
    public partial class AppointmentForm : Form
    {
        private string patientId;
        private string doctorId;
        DatabaseManager database;
        DateTime selectedDate;
        public AppointmentForm(string patientId, string doctorId)
        {
            InitializeComponent();
            database = new DatabaseManager();
            this.patientId = patientId;
            this.doctorId = doctorId;
            LoadAvailableTimes();
            this.FormClosing += new FormClosingEventHandler(MainForm_FormClosing);

        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
           // Application.Exit();
        }
        










        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            if (comboBoxTime.SelectedItem != null)
            {
                DateTime selectedTime = DateTime.ParseExact(comboBoxTime.SelectedItem.ToString(), "hh:mm tt", null);

                selectedDate = dateTimePicker.Value.Date;

                DateTime appointmentDateTime = selectedDate.Add(selectedTime.TimeOfDay);

                database.SaveAppointment(patientId, doctorId, "Upcoming", appointmentDateTime);
                MessageBox.Show($"Your Appointment Has been booked \n at {appointmentDateTime}");

                this.Hide();
            }
            else
            {
                MessageBox.Show("Please select a time.");
            }
        }

        private void LoadAvailableTimes()
        {
            selectedDate = dateTimePicker.Value.Date;
            dateTimePicker.MinDate = DateTime.Now.Date; 
            comboBoxTime.Items.Clear();
            DateTime now = DateTime.Now;

            var bookedTimes = database.GetBookedAppointmentTimes(doctorId, selectedDate, selectedDate.AddDays(1)); // Only for the selected day

            HashSet<DateTime> bookedTimesSet = new HashSet<DateTime>(bookedTimes);

            HashSet<string> addedTimeSlots = new HashSet<string>();

            DateTime startTime = selectedDate.AddHours(14); 
            DateTime endTime = selectedDate.AddHours(21.5);   

            if (selectedDate.Date == now.Date)
            {
                if (now.TimeOfDay > TimeSpan.FromHours(14))
                {
                    startTime = now.AddMinutes(30 - (now.Minute % 30));
                }

                if (now.TimeOfDay >= TimeSpan.FromHours(20.5))
                {
                    return; 
                }
            }

            for (DateTime timeSlot = startTime; timeSlot < endTime; timeSlot = timeSlot.AddMinutes(30))
            {
                if (timeSlot.TimeOfDay == TimeSpan.FromHours(20.5))
                {
                    break;
                }
                string timeSlotString = timeSlot.ToString("hh:mm tt");
                if (!bookedTimesSet.Contains(timeSlot) && !addedTimeSlots.Contains(timeSlotString))
                {
                    comboBoxTime.Items.Add(timeSlotString);
                    addedTimeSlots.Add(timeSlotString); 
                }
            }
        }


        private void labelTime_Click(object sender, EventArgs e)
        {

        }

        private void AppointmentForm_Load(object sender, EventArgs e)
        {

        }

        private void comboBoxTime_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}