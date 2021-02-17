using Microsoft.AspNetCore.Mvc;
using SmartSchool.API.Data;
using System;
using SmarSchool.API.Entities;
using System.Linq;

namespace SmartSchool.API.Controllers {
    [ApiController]
    [Route("api/[controller]")]
    public class StudentController : ControllerBase {

        private readonly SmartSchoolContext _context;

        public StudentController(SmartSchoolContext ctx) {
            _context = ctx;
        }

        // GET: api/<StudentController>
        [HttpGet]
        public IActionResult Get(int offSet = 0, int pageSize = 3) {
            // improve in the future
            return Ok(_context.students.Skip(offSet).Take(pageSize));
        }

        // GET api/<StudentController>/5
        [HttpGet("{id}")]
        public IActionResult GetById(int id) {
            var student = _context.students.FirstOrDefault(s => s.Id == id);

            if (student == null) {
                return BadRequest("Th student was not found");
            }

            return Ok(student);
        }

        // GET api/<StudentController>/peter
        [HttpGet("{id}")]
        public IActionResult GetByName(string name, string lastName)
        {
            var student = _context.students.FirstOrDefault(s => s.Name.Contains(name) && s.LastName.Contains(lastName));

            if (student == null) {
                return BadRequest("Th student was not found");
            }

            return Ok(student);
        }

        // POST api/<StudentController>
        [HttpPost]
        public void Post([FromBody] string value) {
        }

        // PUT api/<StudentController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value) {
        }

        // DELETE api/<StudentController>/5
        [HttpDelete("{id}")]
        public void Delete(int id) {
        }
    }
}
