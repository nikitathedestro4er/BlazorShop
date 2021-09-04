namespace BlazorShop.Shared
{
    public class CartItem
    {
        public int ProductId { get; set; }

        public string ProductTitle { get; set; }
        public decimal Price { get; set; }
        public string Image { get; set; }

        public int Quantity { get; set; }
    }
}