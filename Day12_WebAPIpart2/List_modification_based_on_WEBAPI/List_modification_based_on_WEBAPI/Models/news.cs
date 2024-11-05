using System.ComponentModel.DataAnnotations;

namespace List_modification_based_on_WEBAPI.Models
{
    public class news
    {

        public int id { get; set; }
        //[RegularExpression(@"^[A-Za-z\s]*$", ErrorMessage = "Title can only contain letters and spaces.")]

        public string title { get; set; }
        public string description { get; set; }
        //[RegularExpression(@"^[A-Za-z\s]*$", ErrorMessage = "Title can only contain letters and spaces.")]

        public string Auth_name { get; set; }
    }
}
