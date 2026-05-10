using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                var userInfo = sunnyDB.Users.FirstOrDefault(u => u.id == _id);
                if (userInfo != null)
                {
                    var oldPw = Utils.HashPassword(TB_OldPassword.Text);
                    var newPw = Utils.HashPassword(TB_NewPassword.Text);
                    var confirmPw = Utils.HashPassword(TB_ConfirmNewPassword.Text);


                    var pwCheck = sunnyDB.Users.FirstOrDefault(u => u.Password == oldPw);
                    if(pwCheck == null)
                    {
                        MessageBox.Show("Invalid Password");
                        return;
                    }

                    var check = pwCheck.ToString();
                    if (newPw == check)
                    {
                        MessageBox.Show("New password connect be the same as old");
                        return;
                    }

                    if (newPw != confirmPw)
                    {
                        MessageBox.Show("Passwords do not match. Please try again.");
                        return;

                    }

                    userInfo.Password = newPw;

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
