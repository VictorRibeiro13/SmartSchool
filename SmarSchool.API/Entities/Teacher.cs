using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmarSchool.API.Entities
{
    public class Teacher {
        public int Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<Subject> Subjects { get; set; }

        public Teacher() { }

        public Teacher(int id, string name) {
            Id = id;
            Name = name;
        }
    }
}
