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
    public partial class ManageUsers : Form
    {
        private readonly SunnyCornerCafeWebsite_DBEntities sunnyDB;
        public ManageUsers()
        {
            InitializeComponent();
            sunnyDB = new SunnyCornerCafeWebsite_DBEntities();
        }

        private void BTN_AddNewUser_Click(object sender, EventArgs e)
        {
            try
            {
                var addUser = new AddUser(this);
                addUser.ShowDialog();
            }
            catch (Exception)
            {

                throw;
            }
               
            
        }

        private void BTN_ResetPassword_Click(object sender, EventArgs e)
        {
            try
            {
                //get id from selected row
                var id = (int)GV_UserList.SelectedRows[0].Cells["id"].Value;

                //searches database for a matching record
                var user = sunnyDB.Users.FirstOrDefault(c => c.id == id);

                var HasPassword = Utils.DefaultHashPassword();
                user.Password = HasPassword;

                sunnyDB.SaveChanges();

                MessageBox.Show($"{user.Username}'s Password has been reset");
                PopulateGrid();
            }
            catch (Exception)
            {

                MessageBox.Show("An error occurred while trying to reset password");
            }
           
        }

        private void BTN_EditUser_Click(object sender, EventArgs e)
        {
            //get id from selected row
            var id = (int)GV_UserList.SelectedRows[0].Cells["id"].Value;

            //query database for record
            //var Userid = sunnyDB.Users.FirstOrDefault( c => c.id == id);

            //Launch EditUser window with data
            var EditUser = new EditUser(this, id);
            EditUser.ShowDialog();

        }

        private void ManagerUsers_Load(object sender, EventArgs e)
        {
            try
            {
                PopulateGrid();
            }
            catch (Exception)
            {

                MessageBox.Show(" faild to load users");
            }
        }

        public void PopulateGrid()
        {
            var users = sunnyDB.Users.Select(r => new
            {
                r.id,
                r.Username,
                r.UserRoles.FirstOrDefault().Role.Name,
                r.IsActive
            }).ToList();



            GV_UserList.DataSource = users;
            GV_UserList.Columns["UserName"].HeaderText = "User Name";
            GV_UserList.Columns["name"].HeaderText = "User Role";
            GV_UserList.Columns["isActive"].HeaderText = "User Status";
            //HideS the column for ID. Changed from the hard coded column value to the name, 
            // to make it more dynamic. 
            GV_UserList.Columns["id"].Visible = false;
        }
    }
}
