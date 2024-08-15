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
using ShopWindowsForms.Controls;
using Newtonsoft.Json;
using ShopWindowsForms.Models;

namespace ShopWindowsForms.Controls
{
    public partial class UC_User : UserControl
    {
        private ShopRestClient restClient = new ShopRestClient("http://localhost:5282");
        private GridViewButton gridViewButton = new GridViewButton();
        public readonly Form2 _parent;

        public void FillResponce<T>(Response<T> response)
        {
            dataGridView_User.DataSource = response.Data;
        }

        public UC_User(Form2 parent)
        {
            InitializeComponent();
            _parent = parent;
        }

        public async Task GetAllUsers()
        {
            try
            {
                dataGridView_User.Columns.Clear();
                var result = await restClient.GetAllUsers();
                dataGridView_User.DataSource = result.Data;

                dataGridView_User.Columns.Add(gridViewButton.AddButtonColumn("Update"));
                dataGridView_User.Columns.Add(gridViewButton.AddButtonColumn("Delete"));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void ShowUsers(List<User> users)
        {
            try
            {
                dataGridView_User.Columns.Clear();
                dataGridView_User.DataSource = users;

                dataGridView_User.Columns.Add(gridViewButton.AddButtonColumn("Update"));
                dataGridView_User.Columns.Add(gridViewButton.AddButtonColumn("Delete"));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private async void dataGridView_User_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 4)
                {
                    User user = new User();
                    user.Id = Convert.ToInt32(dataGridView_User.Rows[e.RowIndex].Cells[0].Value.ToString());
                    user.Name = dataGridView_User.Rows[e.RowIndex].Cells[1].Value.ToString();
                    user.Address = dataGridView_User.Rows[e.RowIndex].Cells[2].Value.ToString();
                    user.PhoneNumber = dataGridView_User.Rows[e.RowIndex].Cells[3].Value.ToString();

                    await restClient.Put($"api/Users", user);
                }
                if (e.ColumnIndex == 5)
                {
                    var dataId = dataGridView_User.Rows[dataGridView_User.CurrentRow.Index].Cells[0].Value;
                    await restClient.Delete<string>($"api/Users/{dataId}");
                    await GetAllUsers();
                }
            }
            catch (Exception ex)//EXEPTION 
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button_Create_Click(object sender, EventArgs e)
        {
            try
            {
                UC_CreateUser createUser = new UC_CreateUser(this);
                createUser.OnBack += (o, a) => _parent.SetOnTop(this);
                createUser.AddClick += (o, a) => _parent.SetOnTop(this);
                _parent.SetOnTop(createUser);
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
                var searchDate = await restClient.Get<List<User>>($"api/Users/GetByKeyword?keyword={tbUs_Search.Text ?? ""}");
                 ShowUsers(searchDate.Data);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString());
            }
        }
    }
}
