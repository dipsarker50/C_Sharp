using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using Database;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{
    public partial class InsertDoctor : Form
    {
        DatabaseManager database;
        public InsertDoctor()
        {
            database = new DatabaseManager();
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(MainForm_FormClosing);

        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
           // Application.Exit();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void InsertDoctor_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private string SaveDoctorImage(string originalFilePath, int doctorId)
        {
            string folderPath = @"D:\Project 1\WinFormsApp1\images\DoctorPictures"; // Ensure this folder exists or create it
            Directory.CreateDirectory(folderPath);

            // Save the image with the doctorId in the filename
            string fileName = $"doctor_{doctorId}{Path.GetExtension(originalFilePath)}";
            string newFilePath = Path.Combine(folderPath, fileName);

            ResizeAndSaveImage(originalFilePath, newFilePath, 150, 129); // Save the resized image

            return newFilePath; // Return the path where the image is saved
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

                    resizedImage.Save(newFilePath, ImageFormat.Jpeg); // Save the resized image
                }
            }
        }



        private void browse_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text; string spec = textBox2.Text; string phone = textBox3.Text;
            openFileDialog1.Filter = "Image Files (*.jpg; *.jpeg; *.png)|*.jpg;*.jpeg;*.png";
            openFileDialog1.Title = "Select an Image";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string originalFilePath = openFileDialog1.FileName;

                // Insert the doctor without the image and get the newly generated DoctorId
                int doctorId = database.InsertDoctorAndGetId(name, spec, phone); // Name, Speciality, Phone

                // Save the image with the DoctorId
                string imagePath = SaveDoctorImage(originalFilePath, doctorId);

                // Update the doctor's record with the image path
                database.UpdateDoctorImagePath(doctorId, imagePath);

                // Display the image in the PictureBox
                userPic.Image = System.Drawing.Image.FromFile(imagePath);


                
                this.Hide();

            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void userPic_Click(object sender, EventArgs e)
        {

        }

        private void browse_Click_1(object sender, EventArgs e)
        {

        }
    }
}
