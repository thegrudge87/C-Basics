using System;
using System.Globalization;
class ExchangeIfGreater
{
    static void Main()
    {
        // input
        double a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        double b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        // execute
        if (a > b)
        {
            Console.WriteLine("{1} {0}", a, b);
        }
        else
        {
            Console.WriteLine("{0} {1}", a, b);
        }
    }
}