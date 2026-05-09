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
    public partial class SignUpForm : Form
    {
        private readonly SunnyCornerCafeWebsite_DBEntities sunnyDB;
        public SignUpForm()
        {
            InitializeComponent();
            sunnyDB = new SunnyCornerCafeWebsite_DBEntities();
        }

        private void LB_SignInHere_Click(object sender, EventArgs e)
        {

            var loginForm = new LogInForm(this);
            loginForm.Show();

            this.Hide();
        }

        private void BTN_SignUp_Click(object sender, EventArgs e)
        {

            try
            {
                SHA256 sha = SHA256.Create();// Create a SHA256 hash object


                //collects information entered by user
                var userName = TB_UserName.Text.Trim();
                var email = TB_Email.Text.Trim();
                var password = Utils.HashPassword(TB_Password.Text);
                var confirmPassword = Utils.HashPassword(TB_ConfirmPassword.Text);


                //checks if any field is empty
                if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password)
                    || string.IsNullOrEmpty(confirmPassword))
                {
                    MessageBox.Show("Please fill in all fields.");
                    return;
                }

                //checks if username already exist in Database
                var user = sunnyDB.Users.FirstOrDefault(u => u.Username == userName);
                if (user != null)
                {
                    MessageBox.Show("Username already exists. Please use a different username.");
                    return;
                }

                //checks if email already exists in Database
                var emailExists = sunnyDB.Users.FirstOrDefault(u => u.Email == email);
                if (emailExists != null)
                {
                    MessageBox.Show("Email already exists. Please use a different email.");
                    return;
                }

                //checks if password and confirm password are same
                if (password != confirmPassword)
                {
                    MessageBox.Show("Passwords do not match. Please try again.");
                    return;

                }

                //creates new user and saves to database if username is unique and password is confirmed
                if (user == null && password == confirmPassword) {
                    var newUser = new User
                    {
                        Username = userName,
                        Email = email,
                        Password = password,
                        CreatedDate = DateTime.Now,
                        IsActive = true
                    };
                    sunnyDB.Users.Add(newUser);
                    sunnyDB.SaveChanges();

                    var newUserId = newUser.id;

                    var userRoles = new UserRole
                    {
                        RoleId = 3,
                        UserId = newUserId
                    };
                    sunnyDB.UserRoles.Add(userRoles);
                    sunnyDB.SaveChanges();

                    MessageBox.Show("User registered successfully!", "Success", MessageBoxButtons.OK);

                    var LoginForm = new LogInForm(this);
                    LoginForm.Show();
                    this.Hide();
                    
                }

                

            }
            catch (Exception ex)
            {

                //MessageBox.Show("An error occurred while registering the user. Please try again.");
                MessageBox.Show("Error: " + ex.Message);
            }
            
        }
    }
}
