using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;

namespace SunnyCornerCafeApp
{
    public partial class EditInformation : Form
    {
        private readonly SunnyCornerCafeWebsite_DBEntities sunnyDB;
        private readonly UserInformation _userInfo;
        private readonly int _id;
        private string selectedImagePath; // store uploaded image path

        public EditInformation(int userId, UserInformation userInfo = null)
        {
            InitializeComponent();
            sunnyDB = new SunnyCornerCafeWebsite_DBEntities();
            _userInfo = userInfo;
            _id = userId;
            PopulateField(); // load the user’s data into the form
        }

        private void LLB_ChangeImg_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                using (OpenFileDialog ofd = new OpenFileDialog())
                {
                    ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
                    ofd.Title = "Select an Image";

                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        string sourcePath = ofd.FileName;

                        // Create folder if missing
                        string imagesFolder = Path.Combine(Application.StartupPath, "Images", "Users");
                        Directory.CreateDirectory(imagesFolder);

                        // Copy file into app folder
                        string fileName = Path.GetFileName(sourcePath);
                        string destPath = Path.Combine(imagesFolder, fileName);
                        File.Copy(sourcePath, destPath, true);

                        // Save relative path for DB
                        selectedImagePath = Path.Combine("Images", "Users", fileName);

                        // Preview in PictureBox (add PB_UserImage to your form)
                        PB_UserPicture.Image = Image.FromFile(destPath);
                    }
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Error While uploading image, please try again after restarting the app");
            }
            
        }

        private void BT_Change_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Are you sure you want to save these changes?",
                    "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result != DialogResult.Yes)
                {
                    return;
                }

                var userInfo = sunnyDB.Users.FirstOrDefault(u => u.id == _id);

                if (userInfo != null)
                {
                    userInfo.Name = TB_CName.Text.Trim();
                    userInfo.Username = TB_CUserName.Text.Trim();
                    userInfo.Mobile = TB_CTelephone.Text.Trim();
                    userInfo.Email = TB_CEmail.Text.Trim();
                    userInfo.Address = TB_CAddress.Text.Trim();

                    // Save image path if uploaded
                    if (!string.IsNullOrEmpty(selectedImagePath))
                    {
                        userInfo.ImageUrl = selectedImagePath;
                    }

                    sunnyDB.SaveChanges();

                    MessageBox.Show("User Information updated successfully!");
                    _userInfo?.RefreshFields();
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while updating User Information: " + ex.Message);
            }
        }

        private void PopulateField()
        {
            var user = sunnyDB.Users.FirstOrDefault(u => u.id == _id);

            if (user != null)
            {
                TB_CName.Text = user.Name;
                TB_CUserName.Text = user.Username;
                TB_CEmail.Text = user.Email;
                TB_CAddress.Text = user.Address;
                TB_CTelephone.Text = user.Mobile;

                // Load image if exists
                if (!string.IsNullOrEmpty(user.ImageUrl))
                {
                    string fullPath = Path.Combine(Application.StartupPath, user.ImageUrl);
                    if (File.Exists(fullPath))
                    {
                        PB_UserPicture.Image = Image.FromFile(fullPath);
                    }
                }
            }
        }
    }
}
