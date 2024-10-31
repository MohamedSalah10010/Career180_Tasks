using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstDataBase.Models
{
    public class Author
    {
        [Key]
        public int Auth_ID { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }

        public int age { get; set; }
        
        [Required]
        [StringLength(100)]
        public string UserName { get; set; }
        [StringLength(50)]
        [Required]

        public string Password { get; set; }
        [NotMapped]
        public string Confirm_Password { get; set; }

        [Column("Join_date", TypeName = "date")]
        public DateTime Join_date { get; set; }

        public string Brief { get; set; }

       
        public virtual List<News> News { get; set; }=new List<News>();

        public override string ToString()
        {
            return $"{Auth_ID}-{Name}";
        }
    }
}
