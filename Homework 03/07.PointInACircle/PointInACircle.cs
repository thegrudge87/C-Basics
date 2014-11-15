using System;
using System.Globalization;
class PointInACircle
{
    static void Main()
    {
        double x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        double y = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        double r = 2; //given radius
        //(x - center_x)^2 + (y - center_y)^2 < radius^2
        bool isInCircle = Math.Pow((x - 0), 2) + Math.Pow((y - 0),2) <= r * r; //Math.Pow(x,2) = x*x
        Console.WriteLine(isInCircle);

    }
}