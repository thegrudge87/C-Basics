using System;
using System.Globalization;
class TheBiggestOf3Num
{
    static void Main()
    {
        double max = double.MinValue;

        for (int i = 0; i < 3; i++)
        {
            double number = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            max = Math.Max(max, number);
        }
        Console.WriteLine(max);
    }
}