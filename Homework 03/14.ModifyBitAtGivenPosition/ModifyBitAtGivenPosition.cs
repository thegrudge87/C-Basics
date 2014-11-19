using System;
class Program
{
    static void Main()
    {
        Console.Write("n = ");
        ushort n = ushort.Parse(Console.ReadLine());
        Console.Write("p = ");
        ushort p = ushort.Parse(Console.ReadLine());
        Console.Write("v = ");
        ushort v = ushort.Parse(Console.ReadLine());
        int result;
        if (v == 0)
        {
            int mask0 = ~(1 << p);
            result = n & mask0;
        }
        else 
        {
            int mask1 = 1 << p;
            result = n | mask1;
        }
        Console.WriteLine(result);
    }
}

