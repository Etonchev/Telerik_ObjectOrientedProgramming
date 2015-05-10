using System;
using System.Text;

public static class StringBuiladerSubstring
{
    public static StringBuilder Substring(this StringBuilder input, int index, int length)
    {
        StringBuilder substring = new StringBuilder(input.ToString(), index, length, input.Capacity);
        return substring;
    }
}

public class Test
{
    public static void Main()
    {
        StringBuilder text = new StringBuilder("This is a test");
        StringBuilder substring = text.Substring(5, text.Length - 5);
        Console.WriteLine(substring);
    }
}