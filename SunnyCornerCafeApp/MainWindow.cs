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
        private readonly LogInForm _logInForm;
        private readonly SignUpForm _signUpForm;
        public string _roleName;
        public User _user;
        public MainWindow()
        {
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(MainWindow_FormClosing); // Attach the FormClosing event handler

        }

        public MainWindow(LogInForm logInForm = null, User user = null , SignUpForm signUpForm = null )
        {
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(MainWindow_FormClosing); // Attach the FormClosing event handler
            _logInForm = logInForm;
            _signUpForm = signUpForm;
            _user = user;
            _roleName = user.UserRoles.FirstOrDefault().Role.ShortName;
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
    }
}
