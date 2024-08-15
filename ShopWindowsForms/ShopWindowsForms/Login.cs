using Newtonsoft.Json;
using ShopWindowsForms.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopWindowsForms
{
    public partial class Login : Form
    {
        private ShopRestClient restClient = new ShopRestClient("http://localhost:5282");
        
        // ASP net basic authentication
        // basic authentication vs token authentication
        // ASP net core authentication and authorziation
        // JWT (token) authentication
       //Encoding decoding 
       //Hfunction
       //encription types and use cases
        public Login()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (await CheckCredentials())
            {
                DialogResult = DialogResult.OK;
            }
            else
            {
                DialogResult = DialogResult.No;
            }
        }

        private async Task<bool> CheckCredentials()
        {
            var login = new LoginViewModel();
            login.Username = tb_Log.Text;
            login.Password = tb_Pass.Text;

            var result = await restClient.Post<LoginViewModel ,bool>($"api/Users/CheackLogIn", login);

            return result.Data;
        }
    }
}
