using System;
using System.Globalization;
class Triangle
{
    static void Main()
    {
        // Input data
        double ax = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        double ay = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        double bx = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        double by = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        double cx = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        double cy = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        // Find how long is line AB, BC and AC
        double lineAB = Math.Sqrt(Math.Pow((bx - ax), 2) + Math.Pow((by - ay), 2));
        double lineBC = Math.Sqrt(Math.Pow((cx - bx), 2) + Math.Pow((cy - by), 2));
        double lineAC = Math.Sqrt(Math.Pow((cx - ax), 2) + Math.Pow((cy - ay), 2));

        // Check is the segments can form a triangle.
        if ((lineAB + lineBC > lineAC) && (lineAB + lineAC > lineBC) && (lineBC + lineAC > lineAB))
        {
            Console.WriteLine("Yes");
            double p = (lineAB + lineBC + lineAC)/2.0;
            double Area = Math.Sqrt(p * (p - lineAB)*(p - lineBC)*(p - lineAC));
            Console.WriteLine("{0:0.00}", Area);
        }
        else
        {
            Console.WriteLine("No");
            Console.WriteLine("{0:0.00}", lineAB);
        }
    }
}