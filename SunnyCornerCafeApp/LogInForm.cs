using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SunnyCornerCafeApp
{
    public partial class LogInForm : Form
    {
        private readonly SunnyCornerCafeWebsite_DBEntities sunnyDB;
        public LogInForm()
        {
            InitializeComponent();
            sunnyDB = new SunnyCornerCafeWebsite_DBEntities();
        }

                   
       
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
            try
            {
                SHA256 sha = SHA256.Create();// Create a SHA256 hash object


                var userName = TB_UserName.Text.Trim();
                var password = TB_Password.Text;


                // Convert the password to a byte array and compute the hash
                byte[] passwordBytes = sha.ComputeHash(Encoding.UTF8.GetBytes(password));



                // collects bytes and converts them to a string
                StringBuilder sb = new StringBuilder();



                // Loops through and convert each byte to a hexadecimal string and append it to the StringBuilder
                for (int i = 0; i < passwordBytes.Length; i++)
                {
                    sb.Append(passwordBytes[i].ToString("x2")); // Convert byte to hexadecimal string
                }

                // Get the final hashed password as a string
                var hashedPassword = sb.ToString();

                // Query the database to find a user with the provided username and hashed password
                var user = sunnyDB.Users.FirstOrDefault(u =>
                    u.Username == userName && u.Password == hashedPassword);


                if (user == null)
                {
                    MessageBox.Show("Invalid username or password. Please try again.");

                }
                else
                {
                    var role = user.UserRoles.FirstOrDefault();
                    var roleShortName = role.Role.ShortName;
                    var mainForm = new MainWindow(this,roleShortName, null);
                    mainForm.Show();
                    this.Hide();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Please enter your username and password.");
            }

           

        }
    }

}
