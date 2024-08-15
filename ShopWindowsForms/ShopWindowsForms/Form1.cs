using ShopWindowsForms.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Windows.Forms.VisualStyles;
using ShopWindowsForms.Extensions;

namespace ShopWindowsForms
{
    //harcer
    //producti
    /// put-i mej code karchacnelu paher@
    /// 
    /// Orderi
    /// post-i mej tvyalner chi tasli jsoni xntirsa voncor deserialzaciyaoi
    
    /// User 
    /// Post put xntir api ic ekox 
    public partial class Form1 : Form
    {
        string apiBaseUrl = "http://localhost:5282";
        private ShopRestClient restClient = new ShopRestClient("http://localhost:5282");

        public Form1()
        {
            InitializeComponent();
            comboBox2.SelectedIndex = 0;
            comboBox3.SelectedIndex = 0;
        }

        public void FillResponce<T>(Response<T> response)
        {
            tb_View.Text = response.Content;
        }

        // tab control
        public async Task GetAllProducts()
        {
            //var result = await restClient.Get<List<Product>>("api/Products/GetAll");
             var result = await restClient.GetAllProducts();
            FillResponce(result);
        }

        public async Task GetAllUsers()
        {
            var result = await restClient.Get<List<Product>>("api/Products");
            FillResponce(result);
        }

        public async void GetAllOrders()
        {
            var result = await restClient.Get<List<Product>>("api/Orders");
            FillResponce(result);
        }

        private string GetExampleOf<T>() where T : new()
        {
            return JsonConvert.SerializeObject(new T());
        }

        private async void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            ///Product
            if (comboBox2.Text == "Product" && comboBox3.Text == "Post")
            {
                tb_View.Text = GetExampleOf<Product>();///stex normal chi vercnum stringe
                //tb_View.Text += "{\r\n  \"name\": \"string\",\r\n  \"description\": \"string\",\r\n  \"dataExpiration\": \"string\"\r\n}";
            }
            if (comboBox2.Text == "Product" && comboBox3.Text == "Put")
            {
                tb_View.Text = GetExampleOf<Product>();//"{\r\n  \"id\": 0,\r\n  \"name\": \"string\",\r\n  \"description\": \"string\",\r\n  \"dataExpiration\": \"string\"\r\n}";
            }
            if (comboBox2.Text == "Product" && comboBox3.Text == "Delete")
            {
                await GetAllProducts();
            }
            if (comboBox2.Text == "Product" && comboBox3.Text == "Get")
            {
                await GetAllProducts();
            }
            ///User
            if (comboBox2.Text == "User" && comboBox3.Text == "Post")
            {
                tb_View.Text = "{ \r\n    \"name\": \"string\",\r\n    \"address\": \"string\",\r\n    \"phoneNum\": \"string\",\r\n    \"orders\": null\r\n  }";// GetExampleOf<User>();//"{ \r\n    \"name\": \"string\",\r\n    \"address\": \"string\",\r\n    \"phoneNum\": \"string\",\r\n    \"orders\": null\r\n  }";
            }
            if (comboBox2.Text == "User" && comboBox3.Text == "Put")
            {
                tb_View.Text = GetExampleOf<User>();
            }
            if (comboBox2.Text == "User" && comboBox3.Text == "Delete")
            {
                await GetAllUsers();
            }
            if (comboBox2.Text == "User" && comboBox3.Text == "Get")
            {
                await GetAllUsers();
            }
            ///Order
            if (comboBox2.Text == "Orders" && comboBox3.Text == "Post")
            {
                tb_View.Text = GetExampleOf<Order>();
            }
            if (comboBox2.Text == "Orders" && comboBox3.Text == "Put")
            {
                tb_View.Text = GetExampleOf<Order>();
            }
            if (comboBox2.Text == "Orders" && comboBox3.Text == "Delete")
            {
                GetAllOrders();
            }
            if (comboBox2.Text == "Orders" && comboBox3.Text == "Get")
            {
                GetAllOrders();
            }
        }

        private async void btn_search_Click(object sender, EventArgs e)
        {
            ///Products  
            if (comboBox2.SelectedIndex == 0 && comboBox3.SelectedIndex == 0)
            {
                await GetAllProducts();
            }
            if (comboBox2.SelectedIndex == 0 && comboBox3.SelectedIndex == 1)
            {
                //PUT  
                Product prods = JsonConvert.DeserializeObject<Product>(tb_View.Text);

                var result = await restClient.Put("api/Products", prods);
                FillResponce(result);
                textBox_message.Text = result.StatusCode.ToString(); 
            }
            if (comboBox2.SelectedIndex == 0 && comboBox3.SelectedIndex == 2)
            {
                //POST
                Product product = JsonConvert.DeserializeObject<Product>(tb_View.Text);
              
                var result = await restClient.Post("api/Products/Create",product);
                FillResponce(result);
                textBox_message.Text = result.StatusCode.ToString();
            }
            if (comboBox2.SelectedIndex == 0 && comboBox3.SelectedIndex == 3)
            {
                //DELETE
                var message = MessageBox.Show("Are you sure want delete this item?", "kk", MessageBoxButtons.YesNo);
                if (message == DialogResult.Yes)
                {
                    //var url = GetUrl($"api/Product/{textBox_id.Text}");///ste dlelete chi anum
                    var result = await restClient.Delete<object>($"api/Products/{textBox_id.Text}");
                    FillResponce(result);
                    textBox_message.Text = result.StatusCode.ToString();
                    textBox_id.Text = "";
                }
            }
            ///Users
            if (comboBox2.SelectedIndex == 1 && comboBox3.SelectedIndex == 0)
            {
                await GetAllUsers();
            }
            if (comboBox2.SelectedIndex == 1 && comboBox3.SelectedIndex == 1)
            {
                //PUT
                User user = JsonConvert.DeserializeObject<User>(tb_View.Text);///chi ashxatum hin dzevovel not found 404 a tali

                var result =await restClient.Put($"api/Users/{user.Id}", user);
                FillResponce(result);
                textBox_message.Text = result.StatusCode.ToString();
            }
            if (comboBox2.SelectedIndex == 1 && comboBox3.SelectedIndex == 2)
            {
                //POST
                User user = JsonConvert.DeserializeObject<User>(tb_View.Text);///eerrroor eli

                var result = await restClient.Post("api/Users/Create", user);
                FillResponce(result);
                textBox_message.Text=result.StatusCode.ToString();
            }
            if (comboBox2.SelectedIndex == 1 && comboBox3.SelectedIndex == 3)
            {
                //DELETE
                var message = MessageBox.Show("Are you sure want delete this item?", "kk", MessageBoxButtons.YesNo);
                if (message == DialogResult.Yes)
                {
                    var result = await restClient.Delete<object>($"api/Users/{textBox_id.Text}");
                    FillResponce(result);
                    textBox_message.Text = result.StatusCode.ToString();
                }
            }
            ///Orders
            if (comboBox2.SelectedIndex == 2 && comboBox3.SelectedIndex == 0)
            {
                GetAllOrders();
            }
            if (comboBox2.SelectedIndex == 2 && comboBox3.SelectedIndex == 1)
            {
                ////PUT
                //Order order = JsonConvert.DeserializeObject<Order>(tb_View.Text);

                //var result = await restClient.Put($"api/Orders/{order.Id}", order);
                //FillResponce(result);
                //textBox_message.Text = result.StatusCode.ToString();
            }
            if (comboBox2.SelectedIndex == 2 && comboBox3.SelectedIndex == 2)
            {
                //POST
                Order order = JsonConvert.DeserializeObject<Order>(tb_View.Text);

                var result = await restClient.Post("api/Orders", order);
                FillResponce(result);
                textBox_message.Text= result.StatusCode.ToString();
            }
            if (comboBox2.SelectedIndex == 2 && comboBox3.SelectedIndex == 3)
            {
                //DELETE
                var message = MessageBox.Show("Are you sure want delete this item?", "kk", MessageBoxButtons.YesNo);
                if (message == DialogResult.Yes)
                {
                    var result= await restClient.Delete<string>($"api/Orders/{textBox_id.Text}");
                    FillResponce(result);
                    textBox_message.Text=result.StatusCode.ToString();
                }
            }
        }
    }
}
