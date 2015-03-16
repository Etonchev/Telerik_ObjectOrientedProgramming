using System;
using System.Collections.Generic;

public enum BatteryType { LiIon, NiHM }
public class Battery
{
    private string model;
    private int idleHours;
    private int talkHours;
    public BatteryType type;

    public string Model
    { get; set; }
    public int IdleHours
    { get; set; }
    public int TalkHours
    { get; set; }

    public Battery()
    {
        this.Model = null;
        this.IdleHours = 0;
        this.talkHours = 0;
    }
    public Battery(string model, int idle, int talk, BatteryType type)
    {
        this.Model = model;
        this.IdleHours = idle;
        this.TalkHours = talk;
        this.type = type;
    }
}
public class Display
{
    private double size;
    private long numberOfColors;

    public double Size
    { get; set; }
    public long NumberOfColors
    { get; set; }

    public Display()
    {
        this.Size = 0;
        this.NumberOfColors = 0;
    }
    public Display(double size, long colors)
    {
        this.Size = size;
        this.NumberOfColors = colors;
    }
}
public class GSM
{
    private string manufacturer;
    private string model;
    private double price;
    private string owner;
    private static GSM iPhone4s = new GSM("Apple", "iPhone 4S");
    Display disp;
    Battery batt;
    private List<Call> callHistory;

    public string Manufacturer
    { get; set; }
    public string Model
    { get; set; }
    public double Price
    { get; set; }
    public string Owner
    { get; set; }

    public List<Call> CallHistory
    { get; set; }

    public GSM(string manufacturer, string model)
    {
        this.Manufacturer = manufacturer;
        this.Model = model;
        this.batt = new Battery();
        this.disp = new Display();
    }
    public GSM(string manufacturer, string model, double price, string owner, Display disp, Battery batt) : this (manufacturer, model)
    {
        this.Price = price;
        this.Owner = owner;
        this.disp = disp;
        this.batt = batt;
        this.CallHistory = new List<Call>();
    }

    public static GSM IPhone4S
    {
        get { return iPhone4s; }
    }

    public override string ToString()
    {
        string print = String.Format("{0}, {1}, {2}, {3}\n{4}, {5}, {6}\n{7}, {8}", this.Manufacturer, this.Model, this.Price, this.Owner, this.batt.Model, this.batt.IdleHours, this.batt.TalkHours, this.disp.Size, this.disp.NumberOfColors);
        return print;
    }
    public void AddCall(Call current)
    {
        this.CallHistory.Add(current);
    }
    public void WipeCallHistory()
    {
        this.CallHistory.Clear();
    }
    public double CalculateCallPrice(double price)
    {
        double totalPrice = 0;
        foreach (var item in this.CallHistory)
        {
            totalPrice += item.Duration * price;
        }

        return totalPrice;
    }
    public void DeleteCall(Call current)
    {
        for (int i = 0; i < this.CallHistory.Count; i++)
        {
            if (CallHistory[i].Date == current.Date && CallHistory[i].Time == current.Time && CallHistory[i].Duration == current.Duration && CallHistory[i].DialedNumber == current.DialedNumber)
            {
                callHistory.RemoveAt(i);
            }
        }
    }
}

public class Call
{
    private DateTime date;
    private DateTime time;
    private string dialedNumber;
    private int duration;

    public DateTime Date
    {
        get { return this.date; }
    }

    public DateTime Time
    {
        get { return this.time; }
    }

    public string DialedNumber
    {
        get { return this.dialedNumber; }
    }

    public int Duration
    {
        get { return this.duration; }
    }

    public Call(DateTime date, DateTime time, string dialedNumber, int duration)
    {
        this.date = date;
        this.time = time;
        this.dialedNumber = dialedNumber;
        this.duration = duration;
    }

}

class GSMTest
{
    static void Main()
    {
        Display tft = new Display(4.7, 65000);
        Battery liIon = new Battery("BP900", 12, 6, BatteryType.LiIon);
        GSM hd2 = new GSM("HTC", "HD2", 120, "EmZvr", tft, liIon);
        GSM generic = new GSM("China", "One");
        Console.WriteLine(hd2.ToString());
        Console.WriteLine();
        Console.WriteLine(generic.ToString());
        Console.WriteLine();
        Console.WriteLine(GSM.IPhone4S.ToString());
        Console.WriteLine();
        Call first = new Call(DateTime.Now, DateTime.Now, "0888888888", 5);
        Call second = new Call(DateTime.Now, DateTime.Now, "0777777777", 4);
        hd2.AddCall(first);
        hd2.AddCall(second);
        Console.WriteLine(hd2.CalculateCallPrice(0.37));
    }
}