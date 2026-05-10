using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace SunnyCornerCafeApp
{
    public partial class EditPassword : Form
    {
        private readonly SunnyCornerCafeWebsite_DBEntities sunnyDB;
        private readonly int _id;

        public EditPassword(int id )
        {
            InitializeComponent();
            sunnyDB = new SunnyCornerCafeWebsite_DBEntities();
            _id = id;
        }

        private void BTN_Submit_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Are you sure you want to save these changes?",
                "Confirm Log Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result != DialogResult.Yes)
                {
                    return;
                }

                var userInfo = sunnyDB.Users.FirstOrDefault(u => u.id == _id);

                if (userInfo != null)
                {
                    var oldPw = TB_OldPassword.Text;
                    var newPw = TB_NewPassword.Text;
                    var confirmPw = TB_ConfirmNewPassword.Text;

                    if (string.IsNullOrEmpty(oldPw) || string.IsNullOrEmpty(newPw) || string.IsNullOrEmpty(confirmPw))
                    {
                        MessageBox.Show("Please fill in all fields.");
                        return;
                    }

                    var oldPwHashed = Utils.HashPassword(oldPw);

                    // Check old password against this user
                    if (userInfo.Password != oldPwHashed)
                    {
                        MessageBox.Show("Invalid Password");
                        return;
                    }

                    var newPwHashed = Utils.HashPassword(newPw);

                    // Prevent reusing the same password
                    if (newPwHashed == userInfo.Password)
                    {
                        MessageBox.Show("New password cannot be the same as old");
                        return;
                    }

                    // Confirm new password
                    if (newPw != confirmPw)
                    {
                        MessageBox.Show("Passwords do not match. Please try again.");
                        return;
                    }

                    // Update password
                    userInfo.Password = newPwHashed;
                    sunnyDB.SaveChanges();

                    MessageBox.Show("Password Updated");
                    Close();
                }
                
            }
            catch (Exception)
            {

                MessageBox.Show("Fill out all fields");
            }
        }
    }
}
