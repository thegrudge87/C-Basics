using System;
using System.Globalization;
class SumOf3Numbers
{
    static void Main()
    {
        Console.Write("a = ");
        double a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.Write("b = ");
        double b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.Write("c = ");
        double c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.WriteLine("{0} + {1} + {2} = {3}", a, b, c, a+b+c);
    }
}
