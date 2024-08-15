using ShopWindowsForms.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopWindowsForms.Extensions
{
    internal static class ShopApiEx
    {
        public static Task<Response<List<Product>>> GetAllProducts(this ShopRestClient client)
        {
            return client.Get<List<Product>>("api/Products/GetAll");
        }
        public static Task<Response<List<User>>> GetAllUsers(this ShopRestClient client)
        {
            return client.Get<List<User>>("api/Users");
        }
        public static Task<Response<List<Order>>> GetAllOrders(this ShopRestClient client)
        {
            return client.Get<List<Order>>("api/Orders");
        }
    }
}
