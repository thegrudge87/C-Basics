using System;
class NumberComparer
{
    static void Main()
    {
        Console.Write("a = ");
        float a = float.Parse(Console.ReadLine());
        Console.Write("b = ");
        float b = float.Parse(Console.ReadLine());
        Console.WriteLine("The greater number is {0}", Math.Max(a, b));
    }
}
