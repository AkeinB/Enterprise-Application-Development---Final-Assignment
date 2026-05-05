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
        public MainWindow()
        {
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(MainWindow_FormClosing); // Attach the FormClosing event handler

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
                //close all other open forms when the main window is closed
                foreach (Form form in Application.OpenForms.Cast<Form>().ToList())
                {
                    if (form != this) 
                        form.Close();
                }
            }
            
        }
    }
}
