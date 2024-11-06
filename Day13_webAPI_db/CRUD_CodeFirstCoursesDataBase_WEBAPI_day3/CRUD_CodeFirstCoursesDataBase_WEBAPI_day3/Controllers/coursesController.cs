using CRUD_CodeFirstCoursesDataBase_WEBAPI_day3.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
namespace CRUD_CodeFirstCoursesDataBase_WEBAPI_day3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class coursesController : ControllerBase
    {
        courseContext db;
        public coursesController(courseContext db)
        {
            this.db = db;
        }

        [HttpGet]
        public ActionResult<List<courses>> get()
        {

            List<courses> course_list = db.courses.ToList();
            if (course_list.Count == 0) return NotFound();
            return Ok(course_list);
        }

        [HttpDelete("delete{id:int}")]
        public ActionResult<List<courses>> deleteCourse(int id)
        {

            courses courses = db.courses.Where(c => c.ID == id).FirstOrDefault();
            if (courses == null) return NotFound();
            db.courses.Remove(courses);
            db.SaveChanges();
            List<courses> course_list = db.courses.ToList();

            return Ok(course_list);
        }

        [HttpPut("put{id:int}")]
        public IActionResult put(int id, courses course)
        {

            if (course == null) return NotFound(); 
            if (id != course.ID) return BadRequest();
            //courses c = db.courses.Where(c => c.ID == id).FirstOrDefault();
            
            if (ModelState.IsValid)
            {

                //db.Entry(c).State = EntityState.Modified;
                db.Entry(course).State = EntityState.Modified;

                db.SaveChanges();

                return NoContent();
            }
            else return BadRequest(ModelState);

        }

        [HttpPost]
        public IActionResult post(courses course) {

            if(course==null) return BadRequest();
            if (ModelState.IsValid)
            {

                db.courses.Add(course);
                db.SaveChanges();
                return CreatedAtAction("getById", new {id = course.ID  },course);
            }
            return BadRequest(ModelState);
        
        }

        [HttpGet("get{id:int}")]
        public IActionResult getById(int id) { 
        
            courses c = db.courses.Where(c=>c.ID == id).FirstOrDefault();
            if (c == null) return NotFound();
            return Ok(c);
        
        }
        [HttpGet("getbyname{name}")]
        public IActionResult courseByName(string name)
        {

            courses c = db.courses.Where(c => c.Crs_name.ToUpper().Replace(" ", "") == name.ToUpper()).FirstOrDefault();
            if (c == null) return NotFound();
            return Ok(c);

        }
    }
}
