using System;
using System.Linq;

public class Students
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }

    public Students(string firstName, string lastName, int age)
    {
        FirstName = firstName;
        LastName = lastName;
        Age = age;
    }
}

public class Linq
{
    public static void Main()
    {
        Students[] students = new Students[4];
        students[0] = new Students("Emil", "Tonchev", 23);
        students[1] = new Students("Zahari", "Stoqnov", 30);
        students[2] = new Students("Nedelcho", "Bogdanov", 50);
        students[3] = new Students("Aleksander", "Ivanov", 40);
        var firstBeforeLastQuery =
            from student in students
            where student.FirstName.CompareTo(student.LastName) < 0
            select student;

        Console.WriteLine("Students with first name before last name alphabetically:");
        foreach (var item in firstBeforeLastQuery)
        {
            Console.WriteLine("{0} {1}", item.FirstName, item.LastName);
        }

        Console.WriteLine();
        var ageQuery =
            from student in students
            where student.Age >= 18 && student.Age <= 24
            select student;

        Console.WriteLine("Students aged between 18 and 24 years:");
        foreach (var item in ageQuery)
        {
            Console.WriteLine("{0} {1}, Age: {2}", item.FirstName, item.LastName, item.Age);
        }

        Console.WriteLine();
        var OrderByAndThenBy = students.OrderBy((student) => student.FirstName).ThenBy((student) => student.LastName);
        Console.WriteLine("Students sorted by first name and then last name with lambda expressions:");
        foreach (var item in OrderByAndThenBy)
        {
            Console.WriteLine("{0} {1}", item.FirstName, item.LastName);
        }

        Console.WriteLine();
        var OrderByAndThenByLINQ =
            from student in students
            orderby student.FirstName, student.LastName
            select student;

        Console.WriteLine("Students sorted by first name and then last name with LINQ:");
        foreach (var item in OrderByAndThenByLINQ)
        {
            Console.WriteLine("{0} {1}", item.FirstName, item.LastName);
        }

        Console.WriteLine();
    }
}