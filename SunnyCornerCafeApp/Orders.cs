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
        public Orders()
        {
            InitializeComponent();
            sunnyDB = new SunnyCornerCafeWebsite_DBEntities();
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

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        public void PopulateGrid()
        {
            //var Orders = sunnyDB.Orders.Select(o => new
            //{
            //    o.id,
            //    o.OrderNo,
            //    UserName = o.UserId.FirstOrDefault().UserName,
            //    o.Status
            //}).ToList();

            //GV_OrderList.DataSource = Orders;

            //GV_OrderList.Columns["UserName"].HeaderText = "User Name";
            //GV_OrderList.Columns["Status"].HeaderText = "Order Status";
            //GV_OrderList.Columns["id"].Visible = false;
        }
    }
}
