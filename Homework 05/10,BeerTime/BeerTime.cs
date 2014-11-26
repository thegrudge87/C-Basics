using System;
using System.Globalization;
class BeerTime
{
    static void Main()
    {
        string[] dateInput = Console.ReadLine().Split(' ');
        DateTime date = DateTime.Parse(dateInput[0]);
        string designator = dateInput[1].ToUpperInvariant();

        if ( ((designator == "AM") && (date.Hour < 3)) || ((date.Hour >= 1) && (designator == "PM")))
        {
            Console.WriteLine("beer time");
        }
        else 
        {
            Console.WriteLine("non-beer time");
        }
    }
}