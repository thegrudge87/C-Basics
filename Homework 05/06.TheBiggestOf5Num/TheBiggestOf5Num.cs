using System;
using System.Globalization;
class TheBiggestOf5Num
{
    static void Main()
    {
        // Input data
        double numOne = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        double numTwo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        double numThree = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        double numFour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        double NumFive = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        double max = double.MinValue;

        if (max < numOne)
        {
            max = numOne;
        }
        if (max < numTwo)
        {
            max = numTwo;
        }
        if (max < numThree)
        {
            max = numThree;
        }
        if (max < numFour)
        {
            max = numFour;
        }
        if (max < NumFive)
        {
            max = NumFive;
        }
        Console.WriteLine(max);
    }
}