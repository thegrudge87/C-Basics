using System;
using System.Globalization;
class MultiplicationSign
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        double b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        double c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        byte counter = 0;
        string product;

        if ((a == 0 ) || (b == 0) || (c == 0))
        {
            product = "0";
        }
        else
        {
            if (a < 0)
            {
                counter++;
            }
            if (b < 0)
            {
                counter++;
            }
            if (c < 0)
            {
                counter++;
            }

            if (counter % 2 == 0)
            {
                product = "+";
            }
            else
            {
                product = "-";
            }
        }
        Console.WriteLine(product);
    }
}