using System;
using System.Collections.Generic;
using System.Linq;

namespace _02_StudentsAndWorkers
{
    class ClassTest
    {
        public static void Main()
        {
            List<Student> students = new List<Student>();
            students.Add(new Student("Emil", "Tonchev", 6));
            students.Add(new Student("Ilarion", "", 5));
            students.Add(new Student("Lester", "Herrera", 4));
            students.Add(new Student("Debra", "Austin", 4));
            students.Add(new Student("Dan", "Cobb", 2));
            students.Add(new Student("Pauline", "Cox", 2));
            students.Add(new Student("Rick", "Rice", 6));
            students.Add(new Student("Frankie", "Burton", 5));
            students.Add(new Student("Marta", "Wagner", 3));
            students.Add(new Student("Salvatore", "Luna", 5));

            var sortedStudents = students.OrderBy(x => x.Grade).ToList();
            foreach (var item in sortedStudents)
            {
                Console.WriteLine("{0} {1}, Grade: {2}", item.FirstName, item.LastName, item.Grade);
            }

            Console.WriteLine();

            List<Worker> workers = new List<Worker>();
            workers.Add(new Worker("Monika", "Lane", 250.00M, 6));
            workers.Add(new Worker("Holly", "Cohen", 500.00M, 8));
            workers.Add(new Worker("Pete", "Butler", 1000.00M, 8));
            workers.Add(new Worker("Stanley", "Burns", 1250.00M, 7));
            workers.Add(new Worker("Agnes", "Brady", 850.00M, 7));
            workers.Add(new Worker("Hugo", "Byrd", 850.00M, 5));
            workers.Add(new Worker("Nellie", "Lopez", 2000.00M, 8));
            workers.Add(new Worker("Ray", "Santos", 1700.00M, 6));
            workers.Add(new Worker("Mandy", "Stewart", 9000.00M, 8));
            workers.Add(new Worker("Lewis", "Jackson", 3000.00M, 10));

            var sortedWorkers = workers.OrderByDescending(x => x.MoneyPerHour()).ToList();

            foreach (var item in sortedWorkers)
            {
                Console.WriteLine("{0} {1}, Salary: {2}, Work hours: {3}", item.FirstName, item.LastName, item.WeekSalary, item.WorkHoursPerDay);
            }

            Console.WriteLine();
        }
    }
}
