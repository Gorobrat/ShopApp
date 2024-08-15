using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopWindowsForms.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string Data { get; set; }
        public List<OrderItem> Items { get; set; }
    }
}
