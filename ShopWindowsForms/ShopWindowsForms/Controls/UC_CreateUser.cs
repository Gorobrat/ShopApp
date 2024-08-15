using ShopWindowsForms.Extensions;
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
    public partial class UC_CreateUser : UserControl
    {
        private ShopRestClient restClient = new ShopRestClient("http://localhost:5282");
        UC_User _user;
        public UC_CreateUser(UC_User userUI)
        {
            InitializeComponent();
            _user = userUI;
        }

        public event EventHandler OnBack;
        public event EventHandler AddClick;

        private async void button_Add_Click(object sender, EventArgs e)
        {
            try
            {
                CreateUser user = new CreateUser();
                user.Name = textBox_Name.Text;
                user.Address = textBox_Address.Text;
                user.PhoneNumber = textBox_PhoneNum.Text;

                if (textBox_Name.Text != "" && textBox_Address.Text != "" && textBox_PhoneNum.Text != "")
                {
                    await restClient.Post("api/Users/Create", user);
                    AddClick?.Invoke(this, EventArgs.Empty);
                    await _user.GetAllUsers();
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
