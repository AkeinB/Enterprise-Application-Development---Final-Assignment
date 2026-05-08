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
    public partial class EditUser : Form
    {
        private readonly SunnyCornerCafeWebsite_DBEntities sunnyDB;
        private readonly ManageUsers _manageUser;
        private readonly int _userID;
        public EditUser(ManageUsers manageUsers, int userID)
        {
            InitializeComponent();
            sunnyDB = new SunnyCornerCafeWebsite_DBEntities();
            _manageUser = manageUsers;
            _userID = userID;
            PopulateField(); // load the user’s data into the form
        }

        private void BTN_Submit_Click(object sender, EventArgs e)
        {
            try
            {
                var user = sunnyDB.Users.FirstOrDefault(u => u.id == _userID);
                if (user != null)
                {
                    user.Username = TB_UserName.Text;
                    user.IsActive = (bool)CB_UserStatus.SelectedValue;
                    user.UserRoles.FirstOrDefault().RoleId = (int)CB_UserType.SelectedValue;

                    sunnyDB.SaveChanges();
                    MessageBox.Show("User updated successfully!");

                    _manageUser.PopulateGrid(); // refresh main grid
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating user: " + ex.Message);
            }

        }

        private void BTN_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CB_UserStatis_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void EditUser_Load(object sender, EventArgs e)
        {
            var UserType = sunnyDB.Roles
          .Select(c => new
          {
              Id = c.id,
              Name = c.ShortName
          })
          .ToList();
            CB_UserType.DisplayMember = "Name";
            CB_UserType.ValueMember = "Id";
            CB_UserType.DataSource = UserType;
        }

        private void PopulateField()
        {
            try
            {
                var user = sunnyDB.Users.FirstOrDefault(u => u.id == _userID);
                if (user != null)
                {
                    LB_LableID.Text = user.id.ToString();
                    TB_UserName.Text = user.Username;

                    // Bind roles
                    var roles = sunnyDB.Roles
                        .Select(r => new {
                            r.id,
                            Name = r.ShortName
                        })
                        .ToList();

                    CB_UserType.DisplayMember = "ShortName";
                    CB_UserType.ValueMember = "id";
                    CB_UserType.DataSource = roles;
                    CB_UserType.SelectedValue = user.UserRoles.FirstOrDefault().RoleId;

                    // Bind status
                    CB_UserStatus.DataSource = new[]
                    {
                        new { Text = "Active", Value = true },
                        new { Text = "Inactive", Value = false }
                    };
                        CB_UserStatus.DisplayMember = "Text";
                        CB_UserStatus.ValueMember = "Value";
                        CB_UserStatus.SelectedValue = user.IsActive;
                    }
            }
            catch (Exception)
            {

                MessageBox.Show("An Error Occurred while loading user data");
            }
            
        }

    }
}
