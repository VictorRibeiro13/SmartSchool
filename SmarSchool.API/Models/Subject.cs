﻿using System;
using System.Collections.Generic;

namespace SmarSchool.API.Models {
    public class Subject {
        public int Id { get; set; }
        public string Name { get; set; }
        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }
        public IEnumerable<StudentSubject> StudentsInSubject { get; set; }

        public Subject() {}

        public Subject(int id, string name, int teacherId) {
            Id = id;
            Name = name;
            TeacherId = teacherId;
        }
    }
}
