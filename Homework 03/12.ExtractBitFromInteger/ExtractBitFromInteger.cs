using System;
class ExtractBitFromInteger
{
    static void Main()
    {
        Console.Write("n = ");
        ushort n = ushort.Parse(Console.ReadLine());
        Console.Write("p = ");
        int p = int.Parse(Console.ReadLine());
        int npBit = n >> p;
        int bitP = npBit & 1;
        Console.WriteLine("Bit on position {0} -> {1}", p, Convert.ToString(bitP, 2));
    }
}
