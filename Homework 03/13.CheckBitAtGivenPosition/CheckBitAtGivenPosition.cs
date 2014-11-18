using System;
class CheckBitAtGivenPosition
{
    static void Main()
    {
        Console.Write("n = ");
        ushort n = ushort.Parse(Console.ReadLine());
        Console.Write("p = ");
        int p = int.Parse(Console.ReadLine());
        int n3Bit = n >> p;
        int bit3 = n3Bit & 1;
        bool isBit = false;
        if (bit3 == 1)
        {
            isBit = true;
        }
        Console.WriteLine("Bit on position {0} -> {1}", p, isBit);
    }
}

