namespace BlazorDemo.server2.Data
{
    public class ProductModel
    {
        public int Id { get; set; } 
        public string ProductName { get; set; }
        public string ProductDetail { get; set; }
        public virtual CategoryModel CateId { get; set; }
    }
}