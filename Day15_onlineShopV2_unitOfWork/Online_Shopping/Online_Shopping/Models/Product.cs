using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Online_Shopping.Models
{
    public class Product
    {
        [Key]
        public int id { get; set; }
        [MaxLength(100)]
        public string name { get; set; }
        [Column(TypeName="money")]
        public decimal price { get; set; }
        [MaxLength(150)]
        public string? desc { get; set; }
        public int amount { get; set; }
        
        public string? photoPath { get; set; }
        //[NotMapped]
        //public IFormFile Photo { get; set; }

        [ForeignKey("catalog")]
        public int cat_id { get; set; }

        public virtual Catalog catalog { get; set; }

    }
}
