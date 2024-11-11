namespace Online_Shopping_v2.DTOs
{
    public class addProductDTO
    {
        public int? ProductId { get; set; }
        public string ProductName { get; set; }
        public int ProductQuantity { get; set; }

        public decimal ProductPrice { get; set; }

        public string? ProductDescription { get; set; }
        public int ProductCategoryId { get; set; }

        public IFormFile? ProductPhoto { get; set; }
    }
}
