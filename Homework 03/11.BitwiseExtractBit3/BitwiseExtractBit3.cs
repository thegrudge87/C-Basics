using System;
class BitwiseExtractBit3
{
    static void Main()
    {
        Console.Write("n = ");
        ushort n = ushort.Parse(Console.ReadLine());
        int n3Bit = n >> 3;
        int bit3 = n3Bit & 1;
        Console.WriteLine("Bit#3 -> {0}", Convert.ToString(bit3, 2));
    }
}

