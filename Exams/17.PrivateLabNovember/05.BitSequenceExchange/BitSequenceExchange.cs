using System;

class Program
{
    static void Main()
    {
        // Input data
        long n = long.Parse(Console.ReadLine());

        // Execution
        long bit03 = (n & (7 << 3)) >> 3;
        n = n & (~(7 << 3)); // change to zero the bits 3, 4, 5;
        long bit24 = (n & (7 << 24)) >> 24;
        n = n & (~(7 << 24)); // change to zero the bits 24, 25, 26;

        n = n | (bit03 << 24);
        n = n | (bit24 << 3);

        // Output
        Console.WriteLine(n);
    }
}