using System;
using System.Globalization;
class Sort3NumWithIf
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        double b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        double c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        // biggest num A
        if ((a >= b) && (a >= c))
        {
            if (b >= c)
            {
                Console.WriteLine("{0} {1} {2}", a, b, c);
            }
            else
            {
                Console.WriteLine("{0} {2} {1}", a, b, c);
            }
        }
        else if ((b >= a) && (b >= c))
        {
            if (a >= c)
            {
                Console.WriteLine("{1} {0} {2}", a, b,c);
            }
            else
            {
                Console.WriteLine("{1} {2} {0}", a, b, c);
            }
        }
        else
        {
            if (a >= b)
            {
                Console.WriteLine("{2} {0} {1}", a, b, c);
            }
            else
            {
                Console.WriteLine("{2} {1} {0}", a, b, c);
            }
        }
    }
}