using System;
using System.Collections.Generic;

namespace School
{
    class Class
    {
        public List<Student> Students { get; set; }
        public List<Teacher> Teachers { get; set; }
        public string Identifier { get; set; }
        public string Comment { get; set; }

        public Class(List<Student> students, List<Teacher> teachers, string identifier, string comment = "")
        {
            Students = students;
            Teachers = teachers;
            Identifier = identifier;
            Comment = comment;
        }
    }
}