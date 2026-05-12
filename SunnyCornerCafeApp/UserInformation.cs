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
    public partial class UserInformation : Form
    {
        private readonly SunnyCornerCafeWebsite_DBEntities sunnyDB;
        private readonly User _userInfo;
        public UserInformation(User user)
        {
            InitializeComponent();
            sunnyDB = new SunnyCornerCafeWebsite_DBEntities();
            _userInfo = user;
            PopulateField();
        }

        public void PopulateField()
        {
           
            if (_userInfo != null)
            {
                LB_Username.Text = _userInfo.Username;
                TB_Name.Text = _userInfo.Name;
                TB_TelephoneNumber.Text = _userInfo.Mobile;
                TB_Email.Text = _userInfo.Email;
                TB_Address.Text = _userInfo.Address;
                TB_CreateDate.Text = _userInfo.CreatedDate.ToString("yyyy-MM-dd");
            }

        }

        private void BT_Edit_Click(object sender, EventArgs e)
        {
            
            if(_userInfo == null)
            { 
                MessageBox.Show("No user information available.");
                return;
            }

            var editUserInfo = new EditInformation(_userInfo.id, this);
            editUserInfo.ShowDialog();
        }

        private void BT_Close_Click(object sender, EventArgs e)
        {
            Close();
        }
        public void RefreshFields()
        {
            using (var db = new SunnyCornerCafeWebsite_DBEntities())
            {
                var updatedUser = db.Users.FirstOrDefault(u => u.id == _userInfo.id);
                if (updatedUser != null)
                {
                    LB_Username.Text = updatedUser.Username;
                    TB_Name.Text = updatedUser.Name;
                    TB_TelephoneNumber.Text = updatedUser.Mobile;
                    TB_Email.Text = updatedUser.Email;
                    TB_Address.Text = updatedUser.Address;
                    TB_CreateDate.Text = updatedUser.CreatedDate.ToString("yyyy-MM-dd");
                }
            }
        }

        private void BTN_EditPassword_Click(object sender, EventArgs e)
        {

            if (_userInfo == null)
            {
                MessageBox.Show("No user information available.");
                return;
            }
            var editPassword = new EditPassword(_userInfo.id);
            editPassword.ShowDialog();
        }
    }
}
