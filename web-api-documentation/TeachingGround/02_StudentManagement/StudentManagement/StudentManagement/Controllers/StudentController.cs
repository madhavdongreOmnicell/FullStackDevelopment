using Microsoft.AspNetCore.Mvc;
using StudentManagement.Model;

namespace StudentManagement.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentController : ControllerBase
    {
        private static readonly List<Student> _students = new List<Student>();

        [HttpGet]
        public IActionResult Get()
        {
            return new JsonResult(_students);
        }

        [HttpPost]
        public IActionResult Post(Student student)
        {
            _students.Add(student);
            return Ok(student);
        }

        [HttpPut("Update/{id}")]
        public IActionResult Put(int id, Student student)
        {
            var record = _students.FirstOrDefault(x => x.Id == id);
            if (record == null)
            {
                return NotFound();
            }

            record.Name = student.Name;
            return Ok(record);
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var record = _students.FirstOrDefault(x => x.Id == id);
            if (record == null)
            {
                return NotFound();
            }

            _students.Remove(record);
            return Ok();
        }
    }
}
