using System;
using System.Collections.Generic;

namespace School
{
    class ClassTest
    {
        public static void Main()
        {
            List<Student> students = new List<Student>();
            students.Add(new Student("Georgi", 1));
            students.Add(new Student("Vladi", 2));
            students.Add(new Student("Ivan", 3));

            List<Discipline> disciplines = new List<Discipline>();
            disciplines.Add(new Discipline("Informatics", 20, 15));
            disciplines.Add(new Discipline("IT", 10, 10));
            disciplines.Add(new Discipline("SQL", 5, 5, "Optional course"));

            List<Teacher> teachers = new List<Teacher>();
            teachers.Add(new Teacher("Ivanov", disciplines));

            Class twelve = new Class(students, teachers, "D");
        }
    }
}
