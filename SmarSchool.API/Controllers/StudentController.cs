﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SmartSchool.API.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase {
        // GET: api/<StudentController>
        [HttpGet]
        public IEnumerable<string> Get() {
            return new string[] { "SmarSchoolAPI" };
        }

        // GET api/<StudentController>/5
        [HttpGet("{id}")]
        public string Get(int id) {
            return "value";
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