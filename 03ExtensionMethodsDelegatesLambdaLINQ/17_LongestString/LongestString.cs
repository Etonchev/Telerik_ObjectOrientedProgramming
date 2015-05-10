using System;
using System.Linq;

class LongestString
{
    static void Main()
    {
        string[] array = new string[3];
        array[0] = "sample";
        array[1] = "samplesamplesameplesamplesample";
        array[2] = "samplesample";
        Console.WriteLine(array.OrderByDescending(x => x.Length).FirstOrDefault());
    }
}