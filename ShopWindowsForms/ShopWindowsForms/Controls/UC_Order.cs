using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShopWindowsForms.Extensions;
using ShopWindowsForms.Models;

namespace ShopWindowsForms.Controls
{
    public partial class UC_Order : UserControl
    {
        private ShopRestClient restClient = new ShopRestClient("http://localhost:5282");
        private GridViewButton gridViewButton = new GridViewButton();
        public readonly Form2 _parent;

        public UC_Order(Form2 parent)
        {
            InitializeComponent();
            _parent = parent;
        }

        public async Task GetAllOrders()
        {
            try
            {
                dataGridView_Order.Columns.Clear();
                var result = await restClient.GetAllOrders();
                dataGridView_Order.DataSource = result.Data;

                dataGridView_Order.Columns.Add(gridViewButton.AddButtonColumn("Delete"));

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void ShowOrders(List<Order> orders)
        {
            try
            {
                dataGridView_Order.Columns.Clear();
                dataGridView_Order.DataSource = orders;

                dataGridView_Order.Columns.Add(gridViewButton.AddButtonColumn("Delete"));

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private async void dataGridView_Order_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 4)
                {
                    var dataId = dataGridView_Order.Rows[dataGridView_Order.CurrentRow.Index].Cells[0].Value;
                    await restClient.Delete<Order>($"api/Orders/{dataId}");//string
                    await GetAllOrders();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button_Create_Click(object sender, EventArgs e)
        {
            try
            {
                UC_CreateOrder order = new UC_CreateOrder(this);
                order.OnBack += (o, a) => _parent.SetOnTop(this);
                order.AddClick += (o, a) => _parent.SetOnTop(this);
                _parent.SetOnTop(order);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private async void button_search_Click(object sender, EventArgs e)
        {
            var searchDate = await restClient.Get<List<Order>>($"api/Orders/GetByKeyword?keyword={tbOrd_Search.Text ?? ""}");
            ShowOrders(searchDate.Data);
        }
    }
}
