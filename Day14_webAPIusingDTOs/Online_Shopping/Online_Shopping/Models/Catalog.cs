using System.ComponentModel.DataAnnotations;

namespace Online_Shopping.Models
{
    public class Catalog
    {
        [Key]
        public int id { get; set; }
        [Required]
        [MaxLength(50)]
        public string name { get; set; }
        [MaxLength(150)]
        public string? desc { get; set; }

        public virtual List<Product> Products { get; set; }= new List<Product>();
    }
}
