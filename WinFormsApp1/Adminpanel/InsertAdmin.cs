using Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1.Adminpanel
{
    public partial class InsertAdmin : Form
    {
        private DatabaseManager database;
        private string selectedImagePath;
        public InsertAdmin()
        {
            InitializeComponent();
            database = new DatabaseManager();
            this.FormClosing += new FormClosingEventHandler(MainForm_FormClosing);

        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Application.Exit();
        }
        private void userPic_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void browse_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image Files (*.jpg; *.jpeg; *.png)|*.jpg;*.jpeg;*.png";
            openFileDialog1.Title = "Select an Image";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string originalFilePath = openFileDialog1.FileName;
                selectedImagePath = SaveImageToFolder(originalFilePath);
                userPic.Image = Image.FromFile(selectedImagePath);
            }
        }

        private string SaveImageToFolder(string originalFilePath)
        {
            string folderPath = @"D:\Project 1\WinFormsApp1\images\AdminPicture"; // Ensure this folder exists
            Directory.CreateDirectory(folderPath);

            string fileName = Path.GetFileName(originalFilePath);
            string newFilePath = Path.Combine(folderPath, fileName);

            // Resize and save the image if needed
            ResizeAndSaveImage(originalFilePath, newFilePath, 150, 129);
            return newFilePath;
        }

        private void ResizeAndSaveImage(string originalFilePath, string newFilePath, int width, int height)
        {
            using (Image originalImage = Image.FromFile(originalFilePath))
            {
                using (Bitmap resizedImage = new Bitmap(width, height))
                {
                    using (Graphics graphics = Graphics.FromImage(resizedImage))
                    {
                        graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                        graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                        graphics.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
                        graphics.DrawImage(originalImage, 0, 0, width, height);
                    }
                    resizedImage.Save(newFilePath, System.Drawing.Imaging.ImageFormat.Jpeg);
                }
            }
        }

        private void buttonAddAdmin_Click(object sender, EventArgs e)
        {
            string username = textBox5.Text;
            string email = textBox2.Text;
            string password = textBox4.Text;
            string fullName = textBox1.Text;


            // Call the method to insert admin details into the database
            database.InsertAdmin(username, email, password, fullName, selectedImagePath);

            MessageBox.Show("Admin added successfully!");
            this.Close(); // Close the form or reset fields as needed
        }

        private void InsertAdmin_Load(object sender, EventArgs e)
        {

        }

        private void browse_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
