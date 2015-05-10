using System;
using System.Linq;

class DivisibleBy7And3
{
    static void Main()
    {
        int[] array = new int[60];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = i + 1;
        }

        Console.WriteLine("Numbers divisible by 3 and 7 with lambda expression:");
        var divisibleBy7And3 = array.Where(x => x % 3 == 0 && x % 7 == 0);

        foreach (var item in divisibleBy7And3)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine();
        Console.WriteLine("Numbers divisible by 3 and 7 with LINQ:");
        var divisibleBy7And3LINQ =
            from number in array
            where number % 3 == 0 && number % 7 == 0
            select number;

        foreach (var item in divisibleBy7And3LINQ)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine();
    }
}