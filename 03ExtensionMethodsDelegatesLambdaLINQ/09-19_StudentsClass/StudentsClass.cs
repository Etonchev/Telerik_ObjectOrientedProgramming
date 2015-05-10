using System;
using System.Collections.Generic;
using System.Linq;

public class Student
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string FN { get; set; }
    public string Tel { get; set; }
    public string Email { get; set; }
    public List<int> Marks { get; set; }
    public int GroupNumber { get; set; }

    public Student(string firstName, string lastName, string fn, string tel, string email, List<int> marks, int groupNumber)
    {
        FirstName = firstName;
        LastName = lastName;
        FN = fn;
        Tel = tel;
        Email = email;
        Marks = marks;
        GroupNumber = groupNumber;
    }
}

public static class Extensions
{
    public static void printGroup2(this Student student)
    {
        if (student.GroupNumber == 2)
        {
            Console.WriteLine("{0} {1}, FN: {2}, Telephone: {3}, E-mail: {4}, Group: {5}", student.FirstName, student.LastName, student.FN, student.Email, student.Tel, student.GroupNumber);
        }
    }
}

public class Group
{
    public int GroupNumber { get; set; }
    public string DepartmentName { get; set; }
    public Group(int groupName, string departmentName)
    {
        GroupNumber = groupName;
        DepartmentName = departmentName;
    }
}

public class Test
{
    public static void Main()
    {
        List<Student> students = new List<Student>();
        Student eTonchev = new Student("Emil", "Tonchev", "0123406", "0888888888", "asd@asd.bg", new List<int> { 6, 6, 5 }, 2);
        Student example = new Student("Zahari", "Stoqnov", "987606", "0928888888", "asd@asd.bg", new List<int> { 4, 5, 2 }, 2);
        Student example2 = new Student("Nedelcho", "Bogdanov", "123456", "0888888888", "asd@abv.bg", new List<int> { 3, 2, 2 }, 1);
        students.Add(eTonchev);
        students.Add(example);
        students.Add(example2);
        Group first = new Group(1, "IT");
        Group second = new Group(2, "Mathematics");
        List<Group> groups = new List<Group>();
        groups.Add(first);
        groups.Add(second);

        Console.WriteLine("Students from group 2 with LINQ:");
        var studentsFromGroup2 =
            from student in students
            where student.GroupNumber == 2
            orderby student.LastName
            select student;

        foreach (var item in studentsFromGroup2)
        {
            Console.WriteLine("{0} {1}, FN: {2}, Telephone: {3}, E-mail: {4}, Group: {5}", item.FirstName, item.LastName, item.FN, item.Email, item.Tel, item.GroupNumber);
        }

        Console.WriteLine();
        Console.WriteLine("Students from group 2 with extension method:");
        foreach (var item in students)
        {
            item.printGroup2();
        }

        Console.WriteLine();
        Console.WriteLine("Students with email in abv.bg:");
        var emailInAbv =
            from student in students
            where student.Email.Contains("abv.bg")
            select student;

        foreach (var item in emailInAbv)
        {
            Console.WriteLine("{0} {1}, FN: {2}, Telephone: {3}, E-mail: {4}, Group: {5}", item.FirstName, item.LastName, item.FN, item.Email, item.Tel, item.GroupNumber);
        }

        Console.WriteLine();
        Console.WriteLine("Students with telephones in Sofia:");
        var telephonesInSofia =
            from student in students
            where student.Tel.Substring(0, 3) == "092"
            select student;

        foreach (var item in telephonesInSofia)
        {
            Console.WriteLine("{0} {1}, FN: {2}, Telephone: {3}, E-mail: {4}, Group: {5}", item.FirstName, item.LastName, item.FN, item.Email, item.Tel, item.GroupNumber);
        }

        Console.WriteLine();
        Console.WriteLine("Students with at least one excellent mark:");
        var excellentMark =
            from student in students
            where student.Marks.Contains(6)
            select new
            {
                FullName = student.FirstName + " " + student.LastName,
                Marks = student.Marks
            };

        foreach (var item in excellentMark)
        {
            Console.Write("{0}, Marks: ", item.FullName);
            foreach (var mark in item.Marks)
            {
                Console.Write("{0} ", mark);
            }

            Console.WriteLine();
        }

        Console.WriteLine();
        Console.WriteLine("Students with Poor marks:");
        var twoMarks2Count =
            from student in students
            where student.Marks.Contains(2)
            select student;

        foreach (var item in twoMarks2Count)
        {
            Console.WriteLine("{0} {1}, FN: {2}, Telephone: {3}, E-mail: {4}, Group: {5}", item.FirstName, item.LastName, item.FN, item.Email, item.Tel, item.GroupNumber);
        }

        Console.WriteLine();
        Console.WriteLine("Marks for students enrolled in 2006:");
        var studentsFrom2006 =
            from student in students
            where student.FN[5] == '0' && student.FN[6] == '6'
            select student;

        foreach (var item in studentsFrom2006)
        {
            foreach (var mark in item.Marks)
            {
                Console.Write("{0} ", mark);
            }

            Console.WriteLine();
        }

        Console.WriteLine();
        Console.WriteLine("Students from Mathematics department:");
        var mathematicsDepartment =
                from student in students
                join grp in groups on student.GroupNumber equals grp.GroupNumber
                where grp.DepartmentName == "Mathematics"
                select student;

        foreach (var item in mathematicsDepartment)
        {
            Console.WriteLine("{0} {1}, FN: {2}, Telephone: {3}, E-mail: {4}, Group: {5}", item.FirstName, item.LastName, item.FN, item.Email, item.Tel, item.GroupNumber);
        }

        Console.WriteLine();

    }

}