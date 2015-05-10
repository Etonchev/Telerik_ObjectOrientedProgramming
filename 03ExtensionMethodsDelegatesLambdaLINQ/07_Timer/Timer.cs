using System;
using System.Threading;

class Timer
{
    public delegate void TimerDelegate();
    public static void printMessage()
    {
        Console.WriteLine("Greetings ! Loop mode: ON");
    }

    static void Main()
    {
        TimerDelegate timer = new TimerDelegate(printMessage);
        while(true)
        {
            timer();
            Thread.Sleep(500);
        }
    }
}