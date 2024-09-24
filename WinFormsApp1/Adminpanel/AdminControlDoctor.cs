using Database;
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

namespace WinFormsApp1
{
    public partial class AdminControlDoctor : Form
    {
        DatabaseManager database;
        private string Username;

        public AdminControlDoctor(string Username)
        {
            InitializeComponent();
            database = new DatabaseManager();
            LoadTable();
            this.Username = Username;
            this.FormClosing += new FormClosingEventHandler(MainForm_FormClosing);

        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LoadTable()
        {
            dataGridView1.DataSource = database.DoctorTable();  // Load the Doctors table

            if (database.DoctorTable().Rows.Count == 0)
            {
                MessageBox.Show("No data found.");
            }

            // Set column headers and properties
            dataGridView1.Columns["DoctorId"].HeaderText = "ID";
            dataGridView1.Columns["DoctorId"].ReadOnly = true;
            dataGridView1.Columns["Name"].HeaderText = "Full Name";
            dataGridView1.Columns["Specialty"].HeaderText = "Specialty";
            dataGridView1.Columns["PhoneNumber"].HeaderText = "Phone Number";

            // Set column widths
            dataGridView1.Columns["DoctorId"].Width = 60;
            dataGridView1.Columns["Name"].Width = 300;
            dataGridView1.Columns["Specialty"].Width = 300;
            dataGridView1.Columns["PhoneNumber"].Width = 300;

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Get the selected row
                var selectedRow = dataGridView1.SelectedRows[0];
                var doctorId = selectedRow.Cells["DoctorId"].Value.ToString();
                database.DeleteRowFromDatabaseDoctor(doctorId);

                // Refresh DataGridView
                dataGridView1.DataSource = database.DoctorTable();
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                var row = dataGridView1.Rows[e.RowIndex];
                var doctorId = row.Cells["DoctorId"].Value.ToString();
                var columnName = dataGridView1.Columns[e.ColumnIndex].Name;
                var newValue = row.Cells[e.ColumnIndex].Value.ToString();

                // Update database
                database.UpdateCellInDatabaseDoctor(doctorId, columnName, newValue);
            }
        }

        private bool isEditing = false;
        private void button1_Click(object sender, EventArgs e)
        {
            if (isEditing)
            {
                // Save changes and switch to read-only mode
                dataGridView1.ReadOnly = true;
                button1.Text = "Edit Doctor Details";
            }
            else
            {
                // Switch to editable mode
                dataGridView1.ReadOnly = false;
                dataGridView1.Columns["DoctorId"].ReadOnly = true; // Make DoctorId read-only
                button1.Text = "Done";
            }

            isEditing = !isEditing; // Toggle the flag
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Navigate back to Admin Dashboard

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Navigate to Signup form
            new Signup(true).Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Refresh the data grid with updated doctor data
            dataGridView1.DataSource = database.DoctorTable();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            new Admin_Dashboard(database.AdminName(Username), Username).Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            new InsertDoctor().Show();

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            dataGridView1.DataSource = database.DoctorTable();

        }
    }
}
