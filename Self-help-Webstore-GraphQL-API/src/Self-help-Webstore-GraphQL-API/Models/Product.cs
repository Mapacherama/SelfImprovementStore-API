namespace Self_help_Webstore_GraphQL_API.src.Self_help_Webstore_GraphQL_API.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public decimal Price { get; set; }
        public string? Description { get; set; }
        public int Quantity { get; set; }

        public Product()
        {
            Name = string.Empty;
        }
    }
}
