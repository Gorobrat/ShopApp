namespace ShopApiApp.DTOs
{
    public class CreateOrderDTO
    {
        public int UserId { get; set; }
        public string Data { get; set; }
        public required List<OrderItemDTO> Items { get; set; }
        //public int Discount {  get; set; }
    }
}
