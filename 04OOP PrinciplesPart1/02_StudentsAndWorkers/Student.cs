using System;

namespace _02_StudentsAndWorkers
{
    class Student : Human
    {
        public int Grade { get; set; }

        public Student(string firstName, string lastName, int grade)
            : base(firstName, lastName)
        {
            Grade = grade;
        }
    }
}
