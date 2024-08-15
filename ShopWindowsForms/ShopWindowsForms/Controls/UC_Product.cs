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
using ShopWindowsForms;

namespace ShopWindowsForms.Controls
{
    public partial class UC_Product : UserControl
    {
        //private Form2 form = new Form2();
        private ShopRestClient restClient = new ShopRestClient("http://localhost:5282");
        private GridViewButton gridViewButton = new GridViewButton();
        public readonly Form2 _parent;

        public UC_Product(Form2 parent)
        {
            InitializeComponent();
            _parent = parent;
        }

        public async Task GetAllProducts()
        {
            try
            {
                dataGridView_Product.Columns.Clear();
                var result = await restClient.GetAllProducts();
                dataGridView_Product.DataSource = result.Data;

                dataGridView_Product.Columns.Add(gridViewButton.AddButtonColumn("Update"));
                dataGridView_Product.Columns.Add(gridViewButton.AddButtonColumn("Delete"));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void ShowProducts(List<Product> product)
        {
            try
            {
                dataGridView_Product.Columns.Clear();
                dataGridView_Product.DataSource = product;

                dataGridView_Product.Columns.Add(gridViewButton.AddButtonColumn("Update"));
                dataGridView_Product.Columns.Add(gridViewButton.AddButtonColumn("Delete"));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private async void dataGridView_Product_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 4)
                {
                    Product product = new Product();
                    product.Id = Convert.ToInt32(dataGridView_Product.Rows[e.RowIndex].Cells[0].Value.ToString());
                    product.Name = dataGridView_Product.Rows[e.RowIndex].Cells[1].Value.ToString();
                    product.Description = dataGridView_Product.Rows[e.RowIndex].Cells[2].Value.ToString();
                    product.DataExpiration = dataGridView_Product.Rows[e.RowIndex].Cells[3].Value.ToString();

                    await restClient.Put($"api/Products", product);
                }
                if (e.ColumnIndex == 5)
                {
                    var dataId = dataGridView_Product.Rows[dataGridView_Product.CurrentRow.Index].Cells[0].Value;
                    await restClient.Delete<Product>($"api/Products/{dataId}");
                    await GetAllProducts();
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
                UC_CreateProduct createProduct = new UC_CreateProduct(this);
                createProduct.OnBack += (o, a) => _parent.SetOnTop(this);
                createProduct.AddClick += (o, a) => _parent.SetOnTop(this);
                _parent.SetOnTop(createProduct);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private async void button_search_Click(object sender, EventArgs e)
        {
            try
            {
                var searchDate =await restClient.Get<List<Product>>($"api/Products/GetByKeyword?keyword={tbProd_Search.Text ?? ""}");
                ShowProducts(searchDate.Data);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString());
            }
        }
    }
}
