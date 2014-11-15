using System;
using System.Globalization;
class Trapezoids
{
    static void Main()
    {

        double a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        double b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        double h = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.WriteLine(((a+b)/2.0)*h);
    }
}