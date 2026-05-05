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
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
        }

        private void LB_SignInHere_Click(object sender, EventArgs e)
        {
            var loginForm = new LogInForm();
            loginForm.Show();

            this.Hide();
        }

        private void BTN_SignUp_Click(object sender, EventArgs e)
        {
            //Perform Authentication here, if successful

            //set DialogResult to OK to allow the main form to open
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
