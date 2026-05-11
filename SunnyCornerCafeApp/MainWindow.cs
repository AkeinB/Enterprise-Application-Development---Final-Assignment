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
    public partial class MainWindow : Form
    {
        private readonly SunnyCornerCafeWebsite_DBEntities sunnyDB;
        private readonly LogInForm _logInForm;
        private readonly SignUpForm _signUpForm;
        public string _roleName;
        public User _user;
        public MainWindow()
        {
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(MainWindow_FormClosing); // Attach the FormClosing event handler
            sunnyDB = new SunnyCornerCafeWebsite_DBEntities();
        }

        public MainWindow(LogInForm logInForm = null, User user = null , SignUpForm signUpForm = null )
        {
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(MainWindow_FormClosing); // Attach the FormClosing event handler
            _logInForm = logInForm;
            _signUpForm = signUpForm;
            _user = user;
            _roleName = user.UserRoles.FirstOrDefault().Role.ShortName;
            sunnyDB = new SunnyCornerCafeWebsite_DBEntities();
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", 
                "Confirm Exit", MessageBoxButtons.YesNo, 
                MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                e.Cancel = true; // Prevents closing
            }
            else
            {
                if(_logInForm != null && !_logInForm.IsDisposed)
                _logInForm.Close();

                if (_signUpForm != null && !_signUpForm.IsDisposed)
                    _signUpForm.Close();
                //close all other open forms when the main window is closed
                foreach (Form form in Application.OpenForms.Cast<Form>().ToList())
                {
                    if (form != this) 
                        form.Close();
                }

                // dispose of your DbContext(s) here
                if (sunnyDB != null)
                    sunnyDB.Dispose();
            }
            
        }
        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
           DialogResult result = MessageBox.Show("Are you sure you want to log out?",
            "Confirm Log Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Hide();
                var loginForm = new LogInForm();
                loginForm.Show();
                _user = null;
            }
        }

        //checks what type of user logged in and adjust what they can see or do
        private void MainWindow_Load(object sender, EventArgs e)
        {
            if(_roleName != "admin")
            {
                managerUsersToolStripMenuItem.Visible = false;
            }
        }

        private void managerUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var manageUser = new ManageUsers();
            manageUser.ShowDialog();
        }

       

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var menu= new Menu(_user);
            menu.ShowDialog();
        }

        private void BT_Orders_Click(object sender, EventArgs e)
        {
            var orders = new Orders(_user);
            orders.ShowDialog();
        }

        private void BT_BookTable_Click(object sender, EventArgs e)
        {
            var booktable = new BookTable();
            booktableShowDialog();
        }

        private void BT_Cart_Click(object sender, EventArgs e)
        {
            var cart = new UserCart(_user);
            cart.ShowDialog();
        }

        private void accountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var profile  = new UserInformation(_user);
            profile.ShowDialog();
        }
    }
}
