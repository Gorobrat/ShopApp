namespace ShopApiApp.Model
{
    public class OrderItem
    {
        public int Id { get; set; }
        public virtual Order Order { get; set; }
        public virtual required Product Product { get; set; }
        public int Count { get; set; }
    }
}
