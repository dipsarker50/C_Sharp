using System.Windows.Forms;
using VisualStyles = System.Windows.Forms.VisualStyles;
using Database;
using WinFormsApp1.Patients;
using System.Diagnostics;
using WinFormsApp1.Interface;


namespace WinFormsApp1 {
    public partial class SignIn : Form, ISignIn
    {
        private DatabaseManager database;
        public SignIn()
        {
            InitializeComponent();

            database = new DatabaseManager();

            this.FormClosing += new FormClosingEventHandler(MainForm_FormClosing);

        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }


        private void Form1_Load(object sender, EventArgs e)
        {



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TextBox_Enter(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            textBox.BorderStyle = BorderStyle.FixedSingle;
            textBox.BackColor = Color.LightYellow;
            textBox.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
        }

        private void TextBox_Leave(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            textBox.BorderStyle = BorderStyle.Fixed3D;
            textBox.BackColor = Color.White;
            textBox.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);// Optional: Revert background color
        }

        private void Panel_Paint(object sender, PaintEventArgs e)
        {
            using (Pen pen = new Pen(Color.Blue, 2))
            {
                e.Graphics.DrawLine(pen, 0, panel1.Height - 1, panel1.Width, panel1.Height - 1);
            }
        }




        private void button1_Click(object sender, EventArgs e)
        {
            string phone = textBox1.Text.Trim();
            string password = textBox2.Text.Trim();

            // Check if fields are empty
            if (string.IsNullOrEmpty(phone) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            // Ensure phone starts with +88 for patients
            if (checkPatient && !phone.StartsWith("+88"))
            {
                phone = "+88" + phone;
            }

            // Authenticate the user based on the selected user type (Patient/Admin)
            if (checkPatient)
            {
                HandlePatientLogin(phone, password);
            }
            else if (checkAdmin)
            {
                HandleAdminLogin(phone, password);
            }
            else
            {
                MessageBox.Show("Select the User type: Admin or Patient.");
            }
        }

        // Handle Patient login
        private void HandlePatientLogin(string phone, string password)
        {
            bool isAuthenticated = database.AuthenticateUser(phone, password);

            if (isAuthenticated)
            {

                MessageBox.Show("Login Success");
                string patientId = database.GetPatientIDByPhone(phone);
                Debug.WriteLine("ID: " + patientId);
                new Patients_Dashboard(patientId).Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid phone number or password.");
            }
        }

        // Handle Admin login
        private void HandleAdminLogin(string phone, string password)
        {
            bool isAuthenticated = database.AuthenticateAdmin(phone, password);

            if (isAuthenticated)
            {
                MessageBox.Show("Login Success");
                string adminName = database.AdminName(phone);
                new Admin_Dashboard(adminName, phone).Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid admin credentials.");
            }
        }


        private void buttonLogin_MouseDown(object sender, MouseEventArgs e)
        {
            Button button = sender as Button;
            button.Location = new Point(button.Location.X + 7, button.Location.Y + 7);
            button.Text = "";
        }

        private void buttonLogin_MouseUp(object sender, MouseEventArgs e)
        {
            Button button = sender as Button;
            button.Location = new Point(button.Location.X - 7, button.Location.Y - 7);
            button.Text = "Sign In";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Signup(false).Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you wish to exit?", "Warning", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {

                Application.Exit();

            }
        }
        bool checkPatient;
        bool checkAdmin;
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                label2.Text = "Phone Number";
                label2.Location = new Point(0, 214);
                checkPatient = true;
            }
            else
            {
                checkPatient = false;
            }

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {

                label2.Text = "Username";
                label2.Location = new Point(50, 214);
                checkAdmin = true;
            }
            else
            {
                checkAdmin = false;
            }


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
