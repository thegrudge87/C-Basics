using System;
class CirclePerimeterAndArea
{
    static void Main()
    {
        Console.Write("r =");
        float r = float.Parse(Console.ReadLine());
        Console.WriteLine("circle perimeter = {0: #.##}", 2 * r * Math.PI);
        Console.WriteLine("circle area = {0: #.##}", Math.PI * r * r);
    }
}
