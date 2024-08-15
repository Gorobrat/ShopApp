using ShopWindowsForms.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShopWindowsForms.Models;
using ShopWindowsForms.Extensions;


namespace ShopWindowsForms
{
    public partial class Form2 : Form
    {
        UC_Product productsView;
        UC_User usersView;
        UC_Order orderView;

        public Form2()
        {
            InitializeComponent();
            productsView = new UC_Product(this);
            usersView= new UC_User(this);
            orderView = new UC_Order(this);

            var login = new Login();

            while (login.ShowDialog() == DialogResult.No)
            {
            }
        }

        public void SetOnTop(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }
      
        private async void btn_product_Click(object sender, EventArgs e)
        {
            try
            {
                SetOnTop(productsView);
                await productsView.GetAllProducts();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private async void btn_User_Click(object sender, EventArgs e)
        {
            try
            {
                SetOnTop(usersView);
                await usersView.GetAllUsers();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private async void btn_Order_Click(object sender, EventArgs e)
        {
            try
            {
                SetOnTop(orderView);
                await orderView.GetAllOrders();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
