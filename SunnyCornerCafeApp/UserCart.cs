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
        private readonly SunnyCornerCafeWebsite_DBEntities sunnyDB;
        private readonly User _userInfo;
        public UserCart(User user)
        {
            InitializeComponent();
            sunnyDB = new SunnyCornerCafeWebsite_DBEntities();
            _userInfo = user;
        }

        private void BT_Back_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BT_Checkout_Click(object sender, EventArgs e)
        {
            try
            {
                    var userId = _userInfo.id;
                    var cartItems = sunnyDB.Carts.Where(c => c.UserId == userId).ToList();


                    //checks if items are selected
                    if (!cartItems.Any())
                    {
                        MessageBox.Show("Your cart is empty, please select an item");
                        return;
                    }

                    var order = new Order
                    {
                        OrderNo = Guid.NewGuid().ToString().Substring(0, 8),
                        UserId = userId,
                        OrderDate = DateTime.Now,
                        Status = "Pending"
                    };
                    sunnyDB.Orders.Add(order);
                    sunnyDB.SaveChanges();

                    foreach (var cartItem in cartItems)
                    {
                        sunnyDB.OrderDetails.Add(new OrderDetail
                        {
                            OrderId = order.id,
                            ProductId = cartItem.ProductId,
                            Quantity = cartItem.Quantity,
                        });
                    }

                sunnyDB.Carts.RemoveRange(cartItems); // clear cart
                sunnyDB.SaveChanges();

                var payment = new UserPayment();
                payment.ShowDialog();
                Close();
            }
            catch (Exception)
            {

                MessageBox.Show("An Error Occurred while");
            }

        }

        private void UserCart_Load(object sender, EventArgs e)
        {
            var cartItems = sunnyDB.Carts
                          .Where(c => c.UserId == _userInfo.id)
                          .Select(c => new { Item = c.Product.Name, c.Quantity })
                          .ToList();

            GV_Cart.DataSource = cartItems; // shows cart contents
        }

        private void BT_AddMore_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
