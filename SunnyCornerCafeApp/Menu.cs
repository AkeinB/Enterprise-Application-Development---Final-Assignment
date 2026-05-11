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
        private readonly SunnyCornerCafeWebsite_DBEntities sunnyDB;
        private readonly User _userInfo;
        public Menu( User user)
        {
            InitializeComponent();
            sunnyDB = new SunnyCornerCafeWebsite_DBEntities();
            _userInfo = user;
        }
        private void Menu_Load(object sender, EventArgs e)
        {
            // Reset scroll position to top-left corner when the form loads
            PNL_Menu.AutoScrollPosition = new Point(0, 0);
        }

        private void BT_AddtoCart_Click(object sender, EventArgs e)
        {
            try
            {
                var userId = _userInfo.id;

                if (CB_Coffee.Checked)
                {
                    var product = sunnyDB.Products.FirstOrDefault(p => p.Name == "Coffee");
                    sunnyDB.Carts.Add(new Cart { UserId = userId, ProductId = product.id, Quantity = 1 });
                }
                if (CB_Tea.Checked)
                {
                    var product = sunnyDB.Products.FirstOrDefault(p => p.Name == "Tea");
                    sunnyDB.Carts.Add(new Cart { UserId = userId, ProductId = product.id, Quantity = 1 });
                }
                if (CB_HChoolate.Checked)
                {
                    var product = sunnyDB.Products.FirstOrDefault(p => p.Name == "Hot Chocolate");
                    sunnyDB.Carts.Add(new Cart { UserId = userId, ProductId = product.id, Quantity = 1 });
                }
                if (CB_IceCoffe.Checked)
                {
                    var product = sunnyDB.Products.FirstOrDefault(p => p.Name == "Ice Coffee");
                    sunnyDB.Carts.Add(new Cart { UserId = userId, ProductId = product.id, Quantity = 1 });
                }
                if (CB_Milkshake.Checked)
                {
                    var product = sunnyDB.Products.FirstOrDefault(p => p.Name == "Milkhake");
                    sunnyDB.Carts.Add(new Cart { UserId = userId, ProductId = product.id, Quantity = 1 });
                }
                if (CB_Refreshers.Checked)
                {
                    var product = sunnyDB.Products.FirstOrDefault(p => p.Name == "Refreshers");
                    sunnyDB.Carts.Add(new Cart { UserId = userId, ProductId = product.id, Quantity = 1 });
                }
                if (CB_HamSand.Checked)
                {
                    var product = sunnyDB.Products.FirstOrDefault(p => p.Name == "Hand Sandwhich");
                    sunnyDB.Carts.Add(new Cart { UserId = userId, ProductId = product.id, Quantity = 1 });
                }
                if (CB_Panini.Checked)
                {
                    var product = sunnyDB.Products.FirstOrDefault(p => p.Name == "Panini");
                    sunnyDB.Carts.Add(new Cart { UserId = userId, ProductId = product.id, Quantity = 1 });
                }
                if (CB_Salad.Checked)
                {
                    var product = sunnyDB.Products.FirstOrDefault(p => p.Name == "Salads");
                    sunnyDB.Carts.Add(new Cart { UserId = userId, ProductId = product.id, Quantity = 1 });
                }
                if (CB_Cake.Checked)
                {
                    var product = sunnyDB.Products.FirstOrDefault(p => p.Name == "Cake");
                    sunnyDB.Carts.Add(new Cart { UserId = userId, ProductId = product.id, Quantity = 1 });
                }
                if (CB_Muffin.Checked)
                {
                    var product = sunnyDB.Products.FirstOrDefault(p => p.Name == "Muffin");
                    sunnyDB.Carts.Add(new Cart { UserId = userId, ProductId = product.id, Quantity = 1 });
                }
                if (CB_Cookie.Checked)
                {
                    var product = sunnyDB.Products.FirstOrDefault(p => p.Name == "Cookie");
                    sunnyDB.Carts.Add(new Cart { UserId = userId, ProductId = product.id, Quantity = 1 });
                }

                sunnyDB.SaveChanges();

                // Reset all checkboxes after saving
                CB_Coffee.Checked = false;
                CB_Tea.Checked = false;
                CB_HChoolate.Checked = false;
                CB_IceCoffe.Checked = false;
                CB_Milkshake.Checked = false;
                CB_Refreshers.Checked = false;
                CB_HamSand.Checked = false;
                CB_Panini.Checked = false;
                CB_Salad.Checked = false;
                CB_Cake.Checked = false;
                CB_Muffin.Checked = false;
                CB_Cookie.Checked = false;

                var cart = new UserCart(_userInfo);
                cart.ShowDialog();
                var orders = new Orders(_userInfo);
            }
            catch (Exception)
            {

                MessageBox.Show("Please select an item");
            }
            
        }

        private void BTN_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
