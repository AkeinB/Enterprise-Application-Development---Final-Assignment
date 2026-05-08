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
            try
            {
                var userName = TB_UserName.Text;
                var Role = (int)CB_UserType.SelectedValue;
                var password = Utils.DefaultHashPassword();


                //check to ensure fields are populated
                if(string.IsNullOrEmpty(userName))
                {
                    MessageBox.Show("Please enter an Username");
                    return;
                }

                var userExist = sunnyDB.Users.FirstOrDefault(u =>
                    u.Username == userName);

                if (userExist == null)
                {

                    var user = new User
                    {
                        Username = userName,
                        Password = password,
                        IsActive = true,
                        CreatedDate = DateTime.Now,
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

                    MessageBox.Show("New User added");
                    _addUser.PopulateGrid();
                    Close();
                }
                else
                {
                    MessageBox.Show("Username already exist, please use another name");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("An error occured when creating new user");
            }
           

        }

        private void BTN_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddUser_Load(object sender, EventArgs e)
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
    }
}
