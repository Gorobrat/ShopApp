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
    public partial class UC_CreateProduct : UserControl
    {
        //private readonly TParent _parent;
        private ShopRestClient restClient = new ShopRestClient("http://localhost:5282");
        //private Form2 form = new Form2();
        UC_Product _product;/// vonc anem back aneluc vor cxhtraqi

        public UC_CreateProduct(UC_Product productsUI)
        {
            InitializeComponent();
            _product = productsUI;
        }

        public event EventHandler OnBack;
        public event EventHandler AddClick;

        private async void button_Add_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox_Name.Text != "" && textBox_DataExp.Text != "" && textBox_Description.Text != "")
                {
                    Product product = new Product();
                    product.Name = textBox_Name.Text;
                    product.Description = textBox_Description.Text;
                    product.DataExpiration = textBox_DataExp.Text;

                    await restClient.Post("api/Products/Create", product);
                    AddClick?.Invoke(this, EventArgs.Empty);
                    await _product.GetAllProducts();
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
