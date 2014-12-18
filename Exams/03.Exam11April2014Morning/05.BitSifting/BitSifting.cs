using System;
class BitSifting
{
    static void Main()
    {
        ulong number = ulong.Parse(Console.ReadLine());
        int sievesN = int.Parse(Console.ReadLine());

        for (int i = 0; i < sievesN; i++)
        {
            ulong sieve = ulong.Parse(Console.ReadLine());
            number = number & (~sieve);
        }
        ulong counter = 0;
        while (number > 0)
        {
            counter += number & 1;
            number = number >> 1;
        }
        Console.WriteLine(counter);
    }
}