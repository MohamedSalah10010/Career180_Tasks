using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstDataBase.Models
{
    public class News
    {
        
        [Key]
        public int News_ID { get; set; }
        [MaxLength(100)]
        public string Name { get; set; }

        public string? Description { get; set; }
        public string Brief { get; set; }
                   
        [Column("Issue_Date", TypeName = "date")]
        public DateTime Issued_date { get; set; }

        [ForeignKey("Catalog")]
        public int Cata_id { get; set; }
        [ForeignKey("Author")]
        public int Auth_id { get; set; }

        public virtual Catalog Catalog { get; set; }
        public virtual Author Author { get; set; }




        public override string ToString()
        {
            return $"{News_ID}-{Name}-{Author.Name}-{Catalog.Name}";
        }
    }
}
