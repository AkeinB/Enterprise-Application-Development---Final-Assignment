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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

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

        public void PopulateGrid()
        {
            var Orders = sunnyDB.Order.Select(o => new
            {
                o.id,
                o.OrderNo,
                o.Users.FirstOrDefault().UserName,
                o.Status
            }).ToList();



            GV_OrderList.DataSource = Orders;
            GV_OrderList.Columns["UserName"].HeaderText = "User Name";
            GV_OrderList.Columns["name"].HeaderText = "User Role";
            GV_OrderList.Columns["Status"].HeaderText = "Order Status";
            //HideS the column for ID. Changed from the hard coded column value to the name, 
            // to make it more dynamic. 
            GV_OrderList.Columns["id"].Visible = false;
        }
    }
}
