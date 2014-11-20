using System;
using System.Globalization;

class QuadraticEquation
{
    static void Main()
    {
        Console.Write("a = ");
        float a = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.Write("b = ");
        float b = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.Write("c = ");
        float c = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        // Console.WriteLine("Quadratic Equation - {0}x^2 + {1}x + {2} = 0", a, b, c);

        // Solving the equation
        double discriminant = Math.Pow(b, 2) - 4 * a * c;
        if (discriminant < 0)
        {
            Console.WriteLine("no real roots");
        }
        else
        {
            if (discriminant == 0)
            {
                Console.WriteLine("x1 = x2 = {0:0.#}", -b / (2.0 * a)); 
            }
            else
            {
                Console.WriteLine("x1 = {0:0.#}; x2 = {1:0.#}", (-b - Math.Sqrt(discriminant)) / (2 * a), (-b + Math.Sqrt(discriminant)) / (2 * a));
            }
        }
    }
}