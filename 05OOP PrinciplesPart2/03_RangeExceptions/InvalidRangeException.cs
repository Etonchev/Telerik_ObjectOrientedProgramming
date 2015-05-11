using System;

class InvalidRangeException<T> : Exception
{
    public T Start { get; set; }
    public T End { get; set; }

    private static string ErrorMessage = "Out of range";

    public InvalidRangeException(T start, T end, Exception innerException = null) : base(ErrorMessage, innerException)
    {
        Start = start;
        End = end;
    }
}

class Test
{
    public static void Main()
    {
        try
        {
            int start = 1;
            int end = 100;
            Console.WriteLine("Enter number in range [{0}..{1}]", start, end);
            int number = Convert.ToInt32(Console.ReadLine());
            if (number < start || number > end)
            {
                throw new InvalidRangeException<int>(start, end);
            }
        }
        catch (InvalidRangeException<int> e)
        {
            Console.WriteLine(e.Message);
        }

        try
        {
            DateTime start = new DateTime(1980, 1, 1);
            DateTime end = new DateTime(2013, 12, 31);
            Console.WriteLine("Enter date in range [{0}..{1}]", start, end);
            DateTime input = Convert.ToDateTime(Console.ReadLine());
            if (input < start || input > end)
            {
                throw new InvalidRangeException<DateTime>(start, end);
            }
        }
        catch (InvalidRangeException<DateTime> e)
        {
            Console.WriteLine(e.Message);
        }
    }
}