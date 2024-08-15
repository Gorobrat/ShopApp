using ShopWindowsForms.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopWindowsForms.Controls
{
    public partial class UC_CreateOrder : UserControl
    {
        private ShopRestClient restClient = new ShopRestClient("http://localhost:5282");
        UC_Order _order;

        public UC_CreateOrder(UC_Order orderUI)
        {
            InitializeComponent();
            _order = orderUI;
        }

        public event EventHandler OnBack;
        public event EventHandler AddClick;

        private async void button_Add_Click(object sender, EventArgs e)
        {
            try
            {
                Order order = new Order();
                order.UserId = textBox_UserId.Text;
                //order.Data = textBox_Date.Text;

                if (textBox_UserId.Text != "" /*&& textBox_Date.Text != ""*/)
                {
                    await restClient.Post("api/Orders", order);/// chi mtnum 400 error
                    AddClick?.Invoke(this, EventArgs.Empty);
                    await _order.GetAllOrders();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button_Back_Click(object sender, EventArgs e)
        {
            OnBack?.Invoke(this, EventArgs.Empty);
        }
    }
}
