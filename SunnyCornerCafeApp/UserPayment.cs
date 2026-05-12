using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace SunnyCornerCafeApp
{
    public partial class UserPayment : Form
    {
        public UserPayment()
        {
            InitializeComponent();
        }

        private void BT_Pay_Click(object sender, EventArgs e)
        {
            var cardName = TB_CName.Text;
            var cardNo = MTB_CardNumber.Text;
            var expiryDATE = DateTime.Now.ToString();
            var mailAddress = TB_MAddress.Text;
            var cvv = MTB_CVV.Text;


            if (string.IsNullOrEmpty(cardName) || string.IsNullOrEmpty(cardNo) || string.IsNullOrEmpty(expiryDATE)
                    || string.IsNullOrEmpty(mailAddress) || string.IsNullOrEmpty(cvv))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            Close();
        }

        private void RB_Cash_CheckedChanged(object sender, EventArgs e)
        {
            if (RB_Cash.Checked)
            {
                GB_Cash.Enabled = true;
                GB_Payment.Enabled = false;
            }
        }

        private void RB_Card_CheckedChanged(object sender, EventArgs e)
        {
            if (RB_Card.Checked)
            {
                GB_Cash.Enabled = false;
                GB_Payment.Enabled = true;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BTN_Close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
