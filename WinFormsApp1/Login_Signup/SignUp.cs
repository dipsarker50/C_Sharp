using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Database;

namespace WinFormsApp1
{
    public partial class Signup : Form
    {
      bool fieldchecker;
      
        public Signup(bool fieldchecker)
        {
            InitializeComponent();
            this.AutoScrollPosition = new Point(0, 0);
            this.fieldchecker = fieldchecker;
            this.FormClosing += new FormClosingEventHandler(MainForm_FormClosing);

        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
        }


        public int CalculateAge(DateTime birthDate)
        {
            DateTime today = DateTime.Today;
            int age = today.Year - birthDate.Year;


            if (birthDate.Date > today.AddYears(-age)) age--;

            return age;
        }

        public static string verifyBangladeshiNumber(string inputNumber)
        {

            inputNumber = inputNumber.Replace(" ", "").Replace("-", "");


            string pattern = @"^(?:\+88)?01[0-9]{9}$";
            if (Regex.IsMatch(inputNumber, pattern))
            {
                // Add '+88' if it's not already there
                if (!inputNumber.StartsWith("+88"))
                {
                    inputNumber = "+88" + inputNumber;
                }
                return inputNumber;
            }
            else
            {

                return "0";
            }
        }

        private void Signup_Load(object sender, EventArgs e)
        {
            string firstname = textBox1.Text;
            string address = textBox2.Text;
            string inputphone = textBox3.Text;
            //string phone = verifyBangladeshiNumber(inputphone);
            string disease = textBox4.Text;
            DateTime selectedDate = dateTimePicker1.Value;
            int age = CalculateAge(selectedDate);
            string gender = comboBox1.SelectedItem.ToString();
            string password = textBox5.Text;
            DatabaseManager database = new DatabaseManager();
            if (firstname == null || address == null || inputphone == null || age == 0 || gender == "Default" || password == null)
            {
                MessageBox.Show("All Field should be filled Properly");

            }

            else if (database.PhoneNumberExists(verifyBangladeshiNumber(inputphone)))
            {
                MessageBox.Show("This Number Registered in System \n use different number");
            }

            else if (verifyBangladeshiNumber(inputphone) == "0")
            {
                MessageBox.Show("Invalid Bangladeshi phone number.");
            }

            else if (password.Length <= 8)
            {
                MessageBox.Show("Password Length must be more \n than or equal 8 ");
            }

            else
            {
                database.SaveData(firstname, age, gender, address, disease, verifyBangladeshiNumber(inputphone), password);
                MessageBox.Show("SignUp Successful");
                if (!fieldchecker)
                {
                    new SignIn().Show();
                    this.Hide();

                }
                else
                {
                    this.Hide();
                   
                }
                
            }
        }



        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new SignIn().Show();
            this.Hide();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you wish to exit?", "Warning", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {

                Application.Exit();

            }

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
            button.Text = "Sign Up";
        }

        private void Signup_Load_1(object sender, EventArgs e)
        {
            this.ScrollControlIntoView(this.Controls[0]);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
