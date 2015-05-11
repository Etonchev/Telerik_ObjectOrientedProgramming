using System;

namespace School
{
    class Student : People
    {
        public int ClassNumber { get; set; }
        public string Comment { get; set; }

        public Student(string name, int classNumber, string comment = "")
            : base(name)
        {
            ClassNumber = classNumber;
            Comment = comment;
        }
    }
}