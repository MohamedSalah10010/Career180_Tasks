using List_modification_based_on_WEBAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace List_modification_based_on_WEBAPI.Controllers
{
    [Route("api/news")]
    [ApiController]
    public class newsController : ControllerBase
    {

        static List<news> news_list = new List<news> {
         new news
                {
                    id = 1,
                    title = "Breakthrough in AI",
                    description = "A new AI algorithm promises faster processing and improved accuracy.",
                    Auth_name = "Sarah Johnson"
                },
                new news
                {
                    id = 2,
                    title = "Global Warming Reaches New High",
                    description = "Recent studies show that global warming is increasing at an alarming rate.",
                    Auth_name = "John Doe"
                },
                new news
                {
                    id = 3,
                    title = "Electric Cars on the Rise",
                    description = "Electric vehicles are gaining popularity due to environmental concerns and rising gas prices.",
                    Auth_name = "Emma Wilson"
                },
                new news
                {
                    id = 4,
                    title = "Health Benefits of Meditation",
                    description = "Research shows that daily meditation can help reduce stress and improve mental well-being.",
                    Auth_name = "Mark Thomas"
                },
                new news
                {
                    id = 5,
                    title = "Economic Impact of Inflation",
                    description = "Experts discuss the effects of inflation on global economies and the challenges ahead.",
                    Auth_name = "Rachel Green"
                }
            };


        [HttpGet]
        public IActionResult getall()
        {
            Console.WriteLine( "get all function is being called" );
            return Ok(news_list);
        }

        [HttpGet("title{title:alpha}")]
        //[HttpGet("title={title:alpha}")] --> this work also but not in swagger


        public IActionResult getbytitle(string title)
        {
            news news_obj = news_list.Where(n => n.title.Replace(" ","").ToUpper() == title.ToUpper()).FirstOrDefault();
            //news news_obj = news_list.FirstOrDefault(n => string.Equals(n.title.Replace(" ", ""), title.Replace(" ", ""), StringComparison.OrdinalIgnoreCase)  );
            //string k = title;
            //Console.WriteLine(k.Replace(" ", "").Insert(0, "title").ToUpper());
            if (news_obj == null) return NotFound();
            else return Ok(news_obj);
        }

        
        [HttpGet("author{name:alpha}")]
        public IActionResult getbyauthor(string name)
        {
            news news_obj = news_list.Where(n => n.Auth_name.ToUpper().Replace(" ","") == name.ToUpper()).FirstOrDefault();
            if (news_obj == null)
                return NotFound();//404
            else
                return Ok(news_obj);
        }

        
        [HttpPost]
        public IActionResult add(news news_obj)
        {
            if (news_obj == null) return BadRequest();
            news_list.Add(news_obj);
            return Created();
        }

        [HttpPut("id{id}")]
        public IActionResult edit(int id, news news_obj)
        {
            if (news_obj == null) return BadRequest();
            news news_obj1 = news_list.Where(n => n.id == id).FirstOrDefault();
            if (news_obj1 == null) return NotFound();

            news_obj1.id         = news_obj.id;
            news_obj1.title      = news_obj.title;
            news_obj1.description= news_obj.description;
            news_obj1.Auth_name  = news_obj.Auth_name;

            return NoContent();//204

        }

        [HttpDelete("id{id}")]
        public IActionResult delete(int id)
        {
            news news_obj = news_list.Where(n => n.id == id).FirstOrDefault();
            if (news_obj == null) return NotFound();
            news_list.Remove(news_obj);

            return Ok(news_obj);
        }



    }



    
}
