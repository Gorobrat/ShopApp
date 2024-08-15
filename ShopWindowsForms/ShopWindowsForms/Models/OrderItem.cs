using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopWindowsForms.Models
{
    public class OrderItem
    {
        public int Id { get; set; }
        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }
        public int Count { get; set; }
    }
}
