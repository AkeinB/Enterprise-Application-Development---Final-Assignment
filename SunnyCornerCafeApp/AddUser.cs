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
    public partial class AddUser : Form
    {
        
        private readonly SunnyCornerCafeWebsite_DBEntities sunnyDB;
        private readonly ManageUsers _addUser;
        public AddUser(ManageUsers addUser = null)
        {
            InitializeComponent();
            sunnyDB = new SunnyCornerCafeWebsite_DBEntities();
            _addUser = addUser;
        }

        
        private void BTN_Submit_Click(object sender, EventArgs e)
        {
            var userName = TB_UserName.Text;
            var Role = (int)CB_UserType.SelectedValue;
            var password = Utils.DefaultHashPassword();

            var user = new User
            {
                Username = userName,
                Password = password,
                IsActive = true
            };
            sunnyDB.Users.Add(user);
            sunnyDB.SaveChanges();

            var userid = user.id;
            var userRole = new UserRole
            {
                RoleId = Role,
                UserId = userid,
            };
            sunnyDB.UserRoles.Add(userRole);
            sunnyDB.SaveChanges();
        }

        private void BTN_Cancel_Click(object sender, EventArgs e)
        {

        }

        private void AddUser_Load(object sender, EventArgs e)
        {
            var UserType = sunnyDB.Roles
                 .Select(c => new
                 {
                     c.id,
                     c.ShortName
                 })
                 .ToList();
            CB_UserType.DisplayMember = "Name";
            CB_UserType.ValueMember = "Id";
            CB_UserType.DataSource = UserType;
        }
    }

    
}
