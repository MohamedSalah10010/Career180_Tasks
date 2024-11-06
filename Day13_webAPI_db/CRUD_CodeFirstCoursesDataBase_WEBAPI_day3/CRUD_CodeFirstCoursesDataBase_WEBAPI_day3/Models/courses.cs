using System.ComponentModel.DataAnnotations;

namespace CRUD_CodeFirstCoursesDataBase_WEBAPI_day3.Models
{
    public class courses
    {
        [Key]
        public int ID { get; set; }
        [MaxLength(50)]
        public string? Crs_name { get; set; }
        [MaxLength(150)]
        public string? crs_desc { get; set; }
        public int? Duration { get; set; }
    }
}
