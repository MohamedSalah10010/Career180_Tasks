using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstDataBase.Models
{
    public class Catalog
    {
        
        [Key]
        public int Cata_ID { get; set; }
        
        [MaxLength(50)]
        public string Name { get; set; }

        public string Description { get; set; }


        public virtual List<News> News { get; set; } = new List<News>();

        public override string ToString()
        {
            return $"{Cata_ID}-{Name}";
        }

    }
}
