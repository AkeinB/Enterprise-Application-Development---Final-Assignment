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
    public partial class Orders : Form
    {
        private readonly SunnyCornerCafeWebsite_DBEntities sunnyDB;
        private readonly User _userInfo;
        public Orders(User user)
        {
            InitializeComponent();
            sunnyDB = new SunnyCornerCafeWebsite_DBEntities();
            _userInfo = user;
        }


        private void Orders_Load(object sender, EventArgs e)
        {
            //load data for datagrid
            try
            {
                PopulateGrid();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void BTN_NewOrder_Click(object sender, EventArgs e)
        {
            var menu = new Menu(_userInfo);
            menu.ShowDialog();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Are you sure you want to Cancel this order?",
                "Confirm Log Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result != DialogResult.Yes)
                {
                    return;
                }




                int orderId = (int)GV_OrderList.CurrentRow.Cells["id"].Value;

                var order = sunnyDB.Orders.FirstOrDefault(o => o.id == orderId);
                if (order != null)
                {
                    order.Status = "Cancelled";
                    sunnyDB.SaveChanges();
                    PopulateGrid();
                }
            }
            catch (Exception)
            {

                throw;
            }



        }

        public void PopulateGrid()
        {
            var orders = sunnyDB.Orders
                .Where(o => o.UserId == _userInfo.id)  
                .Select(o => new
                {
                    o.id,
                    o.OrderNo,
                    UserName = o.User.Username,
                    o.OrderDate,
                    o.Status
                })
                .ToList();

            GV_OrderList.DataSource = orders;

            GV_OrderList.Columns["UserName"].HeaderText = "User Name";
            GV_OrderList.Columns["OrderDate"].HeaderText = "Order Date";
            GV_OrderList.Columns["Status"].HeaderText = "Order Status";

            GV_OrderList.Columns["id"].Visible = false;

            GV_OrderList.Columns["OrderDate"].DefaultCellStyle.Format = "yyyy-MM-dd";
        }
    }
}
