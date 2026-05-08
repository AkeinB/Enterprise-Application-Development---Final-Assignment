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
    public partial class UserCart : Form
    {
        public UserCart()
        {
            InitializeComponent();
        }

        private void BT_Back_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BT_Checkout_Click(object sender, EventArgs e)
        {
            var payment = new UserPayment();
            payment.Show();
        }
    }
}
