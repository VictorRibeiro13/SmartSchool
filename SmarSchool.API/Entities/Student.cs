using System;
using System.Collections.Generic;

namespace SmarSchool.API.Entities
{
    public class Student {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public IEnumerable<StudentSubject> StudentsSubject { get; set; }

        public Student() {}

        public Student(int id, string name, string lastName, string phone) {
            Id = id;
            Name = name;
            LastName = lastName;
            Phone = phone;
        }
    }
}
