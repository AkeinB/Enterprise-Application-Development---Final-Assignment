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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void BT_AddtoCart_Click(object sender, EventArgs e)
        {
            var cart = new UserCart();
            cart.Show();
        }

    }
}
