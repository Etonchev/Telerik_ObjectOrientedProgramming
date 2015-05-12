using System;

namespace _01_StudentClass
{
    class ClassTest
    {
        static void Main()
        {
            Student test = new Student("Ivan", "Ivanov", "Ivanov", "123", "Sofia", "0888888888", "asd@asd.bg", "2", Speciality.Mathematics, University.SU, Faculty.FMI);
            Student testCopy = new Student("Ivan", "Ivanov", "Ivanov", "123", "Sofia", "0888888888", "asd@asd.bg", "2", Speciality.Mathematics, University.SU, Faculty.FMI);
            Student testDifferent = new Student("Georgi", "Georgiev", "Georgiev", "321", "Sofia", "0877888888", "dsa@dsa.bg", "3", Speciality.Chemistry, University.Medics, Faculty.Chemists);
            var clone = test.Clone();

            Console.WriteLine(test == testCopy);
            Console.WriteLine(test != testDifferent);
            Console.WriteLine(test.ToString());
            Console.WriteLine();
            Console.WriteLine(clone.ToString());
        }
    }
}
