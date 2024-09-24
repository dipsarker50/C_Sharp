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
using WinFormsApp1.Adminpanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WinFormsApp1
{
    public partial class AdminControl : Form
    {
        DatabaseManager database;
        private string Username;
        public AdminControl(string username)
        {
            InitializeComponent();
            database = new DatabaseManager();
            LoadTable();
            Username = username;
        }

        private void LoadTable()
        {
            dataGridView1.DataSource = database.AdminTable();
            if (database.AdminTable().Rows.Count == 0)
            {
                MessageBox.Show("No data found.");
            }
            dataGridView1.Columns["AdminID"].HeaderText = "ID";
            dataGridView1.Columns["AdminID"].ReadOnly = true;
            dataGridView1.Columns["Username"].ReadOnly = true;
            dataGridView1.Columns["AdminID"].Width = 200;
            dataGridView1.Columns["Username"].Width = 250;
            dataGridView1.Columns["Email"].Width = 250;
            dataGridView1.Columns["FullName"].Width = 250;

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Admin_Dashboard(database.AdminName(Username), Username).Show();
            this.Hide();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Get the selected row
                var selectedRow = dataGridView1.SelectedRows[0];
                var AdminID = selectedRow.Cells["AdminID"].Value.ToString();
                database.DeleteRowFromDatabaseAdmin(AdminID);

                // Refresh DataGridView
                dataGridView1.DataSource = database.AdminTable();
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
                var adminID = row.Cells["AdminID"].Value.ToString();
                var columnName = dataGridView1.Columns[e.ColumnIndex].Name;
                var newValue = row.Cells[e.ColumnIndex].Value.ToString();

                // Update database
                database.UpdateCellInDatabaseAdmin(adminID, columnName, newValue);
                Debug.WriteLine("AdminID: " + adminID);
            }
        }

        private bool isEditing = false;
        private void button1_Click(object sender, EventArgs e)
        {
            if (isEditing)
            {


                dataGridView1.ReadOnly = true;
                button1.Text = "Edit Admin Details";
            }
            else
            {

                dataGridView1.ReadOnly = false;
                dataGridView1.Columns["AdminID"].ReadOnly = true;
                dataGridView1.Columns["Username"].ReadOnly = true;
                button1.Text = "Done";
            }

            isEditing = !isEditing;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = database.AdminTable();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            new InsertAdmin().Show();
            
        }
    }
}
