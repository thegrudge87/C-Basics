using System;
using System.IO;
using System.Globalization;

class Rectangles
{
    static void Main()
    {
        Console.Write("Width: ");
        float width = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.Write("Height: ");
        float height = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.WriteLine("Perimeter = {0}", ((width+height)*2));
        Console.WriteLine("Area = {0}", width*height);
    }
}
