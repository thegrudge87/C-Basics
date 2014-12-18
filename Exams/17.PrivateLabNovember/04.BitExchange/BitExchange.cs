using System;
class BitExchange
{
    static void Main()
    {
        // Input data
        //int n = 1140867093;
        long n = long.Parse(Console.ReadLine());

        long bit03 = (n & (1 << 3)) >> 3;
        long bit24 = (n & (1 << 24)) >> 24;
        n = n & (~(1 << 3)); // change to zero bit03;
        n = n & (~(1 << 24)); // change to zero bit24

        n = n | (bit03 << 24);
        n = n | (bit24 << 3);

        // Output
        Console.WriteLine(n);
    }
}