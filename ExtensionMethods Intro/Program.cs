using System;

//ref link:https://www.youtube.com/watch?v=jkghGK4bdtg&list=PL90AF0EFFEF782D27
// https://www.mindviewllc.com/

//class MainClass
static class MainClass // extension method --added static
{
    //static DateTime Combine(DateTime datePart, DateTime timePart)
    static DateTime Combine(this DateTime datePart, DateTime timePart) // extension method ---added (this
    {
        return new DateTime(
            datePart.Year, datePart.Month, datePart.Day,
            timePart.Hour, timePart.Minute, timePart.Second);
    }
    static void Main()
    {
        DateTime date = DateTime.Parse("1/5/2025");
        DateTime time = DateTime.Parse("1/1/0001 9:55pm");
        //Console.WriteLine(date);
        DateTime combined1 = Combine(date, time);
        DateTime combined2 = date.Combine(time); // extension method .Combine()
        //DateTime combined =
        //new DateTime(
        //date.Year, date.Month, date.Day,
        //time.Hour, time.Minute, time.Second);
        Console.WriteLine(combined1);
        Console.WriteLine(combined2);
    }
}