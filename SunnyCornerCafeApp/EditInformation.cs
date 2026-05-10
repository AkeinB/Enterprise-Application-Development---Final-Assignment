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
    public partial class EditInformation : Form
    {
        private readonly SunnyCornerCafeWebsite_DBEntities sunnyDB;
        private readonly UserInformation _userInfo;
        private readonly int _id;
        public EditInformation(UserInformation userInfo, int userId)
        {
            InitializeComponent();
            sunnyDB = new SunnyCornerCafeWebsite_DBEntities();
            _userInfo = userInfo;
            _id = userId;
            PopulateField(); // load the user’s data into the form
        }

       
        private void LLB_ChangeImg_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void BT_Change_Click(object sender, EventArgs e)
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
                       
                        userInfo.Name = TB_CName.Text.Trim();
                        userInfo.Username = TB_CUserName.Text.Trim();
                        userInfo.Mobile = TB_CTelephone.Text.Trim();
                        userInfo.Email = TB_CEmail.Text.Trim();
                        userInfo.Address = TB_CAddress.Text.Trim();
                        
                        sunnyDB.SaveChanges();

                        MessageBox.Show("User Information updated successfully!");
                        _userInfo.RefreshFields();
                        Close();
                    }
            }
            catch (Exception)
            {

                MessageBox.Show("An Eroor Occurred While updating User Information ");
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
                TB_CEmail.Text = user.Email;
                TB_CTelephone.Text = user.Mobile;


            }
        }

        
    }
}
