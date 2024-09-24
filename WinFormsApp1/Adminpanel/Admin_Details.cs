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
using Database;

namespace WinFormsApp1
{

    public partial class Admin_Details : Form
    {
        private DatabaseManager database;
        private string Username;
        public Admin_Details(String Username)
        {
            InitializeComponent();
            database = new DatabaseManager();
            this.Username = Username;
            LoadUserPicture(Username);
            AdminData();
            this.FormClosing += new FormClosingEventHandler(MainForm_FormClosing);

        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void browse_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image Files (*.jpg; *.jpeg; *.png)|*.jpg;*.jpeg;*.png";
            openFileDialog1.Title = "Select an Image";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                string originalFilePath = openFileDialog1.FileName;
                string _selectedImagePath = SaveImageToFolder(originalFilePath);


                userPic.Image = System.Drawing.Image.FromFile(_selectedImagePath);


            }
        }

        public void LoadUserPicture(string Username)
        {

            string imagePath = database.AdminPicture(Username);

            if (imagePath != null && File.Exists(imagePath))
            {
                userPic.Image = Image.FromFile(imagePath);
            }
            else
            {
                // Handle cases where the image is not found or the path is invalid
                userPic.Image = null; // or set to a default image
            }
        }
        private string SaveImageToFolder(string originalFilePath)
        {

            string folderPath = @"D:\Project 1\WinFormsApp1\images\AdminPicture"; // Ensure this folder exists or create it
            Directory.CreateDirectory(folderPath);


            string fileName = Path.GetFileName(originalFilePath);
            string newFilePath = Path.Combine(folderPath, fileName);


            ResizeAndSaveImage(originalFilePath, newFilePath, 150, 129);

            database.UpdateImagePathInDatabase(Username, newFilePath);


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

                    resizedImage.Save(newFilePath, ImageFormat.Jpeg); // You can change the format if needed
                }
            }
        }

        private void userPic_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Admin_Dashboard(database.AdminName(Username), Username).Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void AdminData()
        {
            textBox1.Text = database.AdminName(Username);
            textBox2.Text = database.AdminEmail(Username);
            textBox3.Text = Username;
            textBox4.Text = database.AdminID(Username);
        }

        private void Admin_Details_Load(object sender, EventArgs e)
        {

        }
        private bool isEditing = false;
        private void edit_Click(object sender, EventArgs e)
        {
            
                if (isEditing)
                {
                   
                    database.SaveData(Username,textBox1.Text,textBox2.Text);
                    
                    edit.Text = "Edit";
   
                    SetTextBoxesReadOnly(true);
                }
                else
                {
                   
                    edit.Text = "Save";
                   
                    SetTextBoxesReadOnly(false);
                }

                isEditing = !isEditing;
         }


        private void SetTextBoxesReadOnly(bool readOnly)
        {
            textBox1.ReadOnly = readOnly;
            textBox2.ReadOnly = readOnly;
        }

    }
}
