using System;
using System.Globalization;
    class InCircleOutRectangle
    {
        static void Main()
        {
            Console.Write("x = ");
            double x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("y = ");
            double y = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            double r = 1.5;

            bool isOutOfRectangle = (y>1)? true : false;
            //(x - center_x)^2 + (y - center_y)^2 < radius^2
            bool isInCircle = Math.Pow((x - 1), 2) + Math.Pow((y - 1),2) <= r * r;
            Console.WriteLine( (isOutOfRectangle && isInCircle) ? "yes" : "no");
        }
    }