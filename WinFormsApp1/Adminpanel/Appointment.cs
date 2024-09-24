using System;
using System.Data;
using System.Windows.Forms;
using Database;
using iTextSharp.text;
using iTextSharp.text.pdf;
using MySqlConnector;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;



namespace WinFormsApp1.Adminpanel
{
    public partial class Appointment : Form
    {
        DatabaseManager database;
        string Username;
        private string connectionString = "Server=localhost;Database=HospitalManagement;User ID=root;Password=12345678!;port=3306"; // Update this with your connection string

        public Appointment(string Username)
        {
            InitializeComponent();
            this.Username = Username;
            LoadPatients();
            LoadDoctors();
            LoadDistinctAppointmentDates();
            comboBox1.SelectedIndexChanged += ComboBox1_SelectedIndexChanged;
            comboBox2.SelectedIndexChanged += ComboBox2_SelectedIndexChanged;
            comboBox3.SelectedIndexChanged += ComboBox3_SelectedIndexChanged;
        }

        private void LoadPatients()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT PatientId, FullName FROM Patients";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        comboBox1.Items.Add(new { Text = reader["FullName"].ToString(), Value = reader["PatientId"] });
                    }
                }
            }
            comboBox1.DisplayMember = "Text";
            comboBox1.ValueMember = "Value";
        }

        private void LoadDoctors()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT DoctorId, Name FROM Doctors";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        comboBox2.Items.Add(new { Text = reader["Name"].ToString(), Value = reader["DoctorId"] });
                    }
                }
            }
            comboBox2.DisplayMember = "Text";
            comboBox2.ValueMember = "Value";
        }

        private void LoadAppointments()
        {
            dataGridView1.DataSource = null; // Clear existing data
            string query = $"SELECT a.AppointmentID, p.FullName as PatientName, d.Name as DoctorName, a.AppointmentStatus, a.AppointmentTime " +
                           $"FROM Appointments a " +
                           $"JOIN Patients p ON a.PatientID = p.PatientId " +
                           $"JOIN Doctors d ON a.DoctorID = d.DoctorId " +
                           $"WHERE 1=1 "; // Base query

            // Check if the patient ComboBox has a selection
            if (comboBox1.SelectedItem != null)
            {
                int patientId = (int)((dynamic)comboBox1.SelectedItem).Value;
                query += $"AND a.PatientID = {patientId} ";
            }

            // Check if the doctor ComboBox has a selection
            if (comboBox2.SelectedItem != null)
            {
                int doctorId = (int)((dynamic)comboBox2.SelectedItem).Value;
                query += $"AND a.DoctorID = {doctorId} " +
                         $"AND DATE(a.AppointmentTime) = CURDATE();"; // Filter for today's appointments
            }

            // Check if the date ComboBox has a selection
            if (comboBox3.SelectedItem != null)
            {
                DateTime selectedDate = (DateTime)comboBox3.SelectedItem;
                query += $"AND DATE(a.AppointmentTime) = '{selectedDate.ToString("yyyy-MM-dd")}' ";
            }

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            using (MySqlCommand command = new MySqlCommand(query, connection))
            using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
            {
                DataTable appointments = new DataTable();
                adapter.Fill(appointments);
                dataGridView1.DataSource = appointments;

                // Configure DataGridView columns
                dataGridView1.Columns["AppointmentID"].HeaderText = "ID";
                dataGridView1.Columns["AppointmentID"].ReadOnly = true;
                dataGridView1.Columns["PatientName"].HeaderText = "Patient Name";
                dataGridView1.Columns["DoctorName"].HeaderText = "Doctor Name";
                dataGridView1.Columns["AppointmentStatus"].HeaderText = "Status";
                dataGridView1.Columns["AppointmentStatus"].ReadOnly = true;
                dataGridView1.Columns["AppointmentTime"].HeaderText = "Appointment Time";
                dataGridView1.Columns["AppointmentTime"].ReadOnly = true;

                // Set column widths
                dataGridView1.Columns["AppointmentID"].Width = 100;
                dataGridView1.Columns["PatientName"].Width = 200;
                dataGridView1.Columns["DoctorName"].Width = 200;
                dataGridView1.Columns["AppointmentStatus"].Width = 150;
                dataGridView1.Columns["AppointmentTime"].Width = 300;
            }
        }

        private void PrintDataGridViewToPDF()
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "PDF Files (*.pdf)|*.pdf";
                saveFileDialog.Title = "Save a PDF File";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (Document document = new Document())
                    {
                        using (FileStream fs = new FileStream(saveFileDialog.FileName, FileMode.Create, FileAccess.Write, FileShare.None))
                        {
                            PdfWriter writer = PdfWriter.GetInstance(document, fs);

                            document.Open();
                            var table = new PdfPTable(dataGridView1.Columns.Count);

                            foreach (DataGridViewColumn column in dataGridView1.Columns)
                            {
                                table.AddCell(new Phrase(column.HeaderText));
                            }

                            foreach (DataGridViewRow row in dataGridView1.Rows)
                            {
                                if (!row.IsNewRow)
                                {
                                    foreach (DataGridViewCell cell in row.Cells)
                                    {
                                        table.AddCell(new Phrase(cell.Value?.ToString() ?? string.Empty));
                                    }
                                }
                            }

                            document.Add(table);
                            document.Close();
                        }
                    }
                    MessageBox.Show("PDF saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }




        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.SelectedIndex = -1;
            comboBox3.SelectedIndex = -1;
            LoadAppointments();
        }

        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = -1;
            comboBox3.SelectedIndex = -1;
            LoadAppointments();
        }

        private void ComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.SelectedIndex = -1;
            comboBox1.SelectedIndex = -1;
            LoadAppointments();
        }

        private void LoadDistinctAppointmentDates()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT DISTINCT DATE(AppointmentTime) as AppointmentDate FROM Appointments";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        comboBox3.Items.Add(reader.GetDateTime("AppointmentDate"));
                    }
                }
            }
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            PrintDataGridViewToPDF();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PrintDataGridViewToPDF();
        }

        private void Appointment_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            database = new DatabaseManager();
            new Admin_Dashboard(database.AdminName(Username), Username).Show();
            this.Hide();
        }
    }

    public class AppointmentDetails
    {
        public int AppointmentID { get; set; }
        public string PatientName { get; set; }
        public string DoctorName { get; set; }
        public string AppointmentStatus { get; set; }
        public DateTime AppointmentTime { get; set; }
    }
}
