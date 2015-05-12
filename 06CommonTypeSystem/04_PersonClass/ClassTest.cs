using System;

namespace _04_PersonClass
{
    class ClassTest
    {
        static void Main()
        {
            Person noAge = new Person("Emil Tonchev");
            Person withAge = new Person("Ivan Ivanov", 35);
            Console.WriteLine(noAge.ToString());
            Console.WriteLine(withAge.ToString());
        }
    }
}
