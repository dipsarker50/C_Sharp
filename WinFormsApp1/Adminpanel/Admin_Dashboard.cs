using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.Adminpanel;

namespace WinFormsApp1
{
    public partial class Admin_Dashboard : Form
    {
        private string Username;
        public Admin_Dashboard(string name, string Username)
        {
            InitializeComponent();
            linkLabel1.Text = name;
            this.Username = Username;
            this.FormClosing += new FormClosingEventHandler(MainForm_FormClosing);

        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new AdminControlDoctor(Username).Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            new AdminControlPatient(Username).Show();
            this.Hide();
        }

        private void Admin_Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Admin_Details(Username).Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new SignIn().Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new AdminControl(Username).Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new Appointment(Username).Show();
            this.Hide();
        }
    }
}
