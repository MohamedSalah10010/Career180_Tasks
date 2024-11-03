using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoursesController : ControllerBase
    {
        List<Courses> courses = new List<Courses> {

           new Courses{id=1,name= "dotnet",duration=10,status=false  },
           new Courses{id=2,name= "C#",duration=8,status=true  },

           new Courses{id=3,name= "java",duration=11,status=true  },
           new Courses{id=4,name= "spring",duration=15,status=false  },
        };

        /*
        ** [
        *   {
        *    "id"= 1,
        *    "name"= "dotnet",
        *    "duration"= 10,
        *    "status" = false
        *   },
        *   
        *  {
        *    "id"= 2,
        *    "name"= "c#",
        *    "duration"= 8,
        *    "status" = true
        *   },
        *   {
        *    "id"= 3,
        *    "name"= "java",
        *    "duration"= 11,
        *    "status" = true
        *   },
        *   {
        *    "id"= 4,
        *    "name"= "spring",
        *    "duration"= 15,
        *    "status" = false
        *   }
        *
        *   ]
        
        */

        [HttpGet]
        public List<Courses> getall() {

            return courses;

        }
        [HttpGet("{id}")]
        public Courses getbyid(int id)
        {
            return courses.Where(c => c.id == id).SingleOrDefault();
           

        }
    }
}
