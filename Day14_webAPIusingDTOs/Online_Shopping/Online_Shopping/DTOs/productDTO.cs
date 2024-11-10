namespace Online_Shopping.DTOs
{
    public class productDTO
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int ProductQuantity { get; set; }

        public decimal ProductPrice { get; set; }

        public string ProductDescription { get; set; }
        public string ProductCategoryName { get; set; }
       
    }
}
