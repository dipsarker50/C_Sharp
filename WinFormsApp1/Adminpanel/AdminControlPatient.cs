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
    public partial class AdminControlPatient : Form
    {
        DatabaseManager database;
        private string Username;
        public AdminControlPatient(string Username)
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
            dataGridView1.DataSource = database.PatientTable();
            if (database.PatientTable().Rows.Count == 0)
            {
                MessageBox.Show("No data found.");
            }
            dataGridView1.Columns["PatientId"].HeaderText = "ID";
            dataGridView1.Columns["PatientId"].ReadOnly = true;
            dataGridView1.Columns["Gender"].ReadOnly = true;
            dataGridView1.Columns["Age"].Width = 60;
            dataGridView1.Columns["PatientId"].Width = 60;
            dataGridView1.Columns["Gender"].Width = 70;
            dataGridView1.Columns["MedicalCondition"].Width = 200;
            dataGridView1.Columns["PhoneNumber"].Width = 200;
            dataGridView1.Columns["FullName"].Width = 190;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }



        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Get the selected row
                var selectedRow = dataGridView1.SelectedRows[0];
                var patientId = selectedRow.Cells["PatientId"].Value.ToString();
                database.DeleteRowFromDatabasePatient(patientId);

                // Refresh DataGridView
                dataGridView1.DataSource = database.PatientTable();
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
                var patientId = row.Cells["PatientId"].Value.ToString();
                var columnName = dataGridView1.Columns[e.ColumnIndex].Name;
                var newValue = row.Cells[e.ColumnIndex].Value.ToString();

                // Update database
                database.UpdateCellInDatabasePatient(patientId, columnName, newValue);
            }
        }

        private bool isEditing = false;
        private void button1_Click(object sender, EventArgs e)
        {
            if (isEditing)
            {
                // Save changes and switch to read-only mode

                dataGridView1.ReadOnly = true;
                button1.Text = "Edit Patients Details";
            }
            else
            {
                // Switch to editable mode
                dataGridView1.ReadOnly = false;
                dataGridView1.Columns["PatientId"].ReadOnly = true;
                dataGridView1.Columns["Gender"].ReadOnly = true;
                button1.Text = "Done";
            }

            isEditing = !isEditing; // Toggle the flag

        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Admin_Dashboard(database.AdminName(Username), Username).Show();
            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Signup(true).Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = database.PatientTable();
        }
    }
}
