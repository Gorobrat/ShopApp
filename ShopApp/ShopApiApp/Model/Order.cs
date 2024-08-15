using System.Collections.Generic;

namespace ShopApiApp.Model
{
    public class Order
    {
        public int Id { get; set; }
        public User User { get; set; }
        public DateTime Date { get; set; }
        public virtual required ICollection<OrderItem> Items { get; set; }
    }
}
