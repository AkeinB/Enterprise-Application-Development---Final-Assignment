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
    public partial class LogInForm : Form
    {
        public LogInForm()
        {
            InitializeComponent();
           
        }

        //Method to confirm exit when the user tries to close the form
       
        private void LogInForm_Load(object sender, EventArgs e)
        {

        }

        private void LB_RegisterHere_Click(object sender, EventArgs e)
        {
            var registerForm = new SignUpForm();
            registerForm.Show();

            this.Hide();

        }

        private void BTN_Login_Click(object sender, EventArgs e)
        {
            //Perform Authentication here, if successful

            //set DialogResult to OK to allow the main form to open
            this.DialogResult = DialogResult.OK;
            this.Close();

        }
    }

}
