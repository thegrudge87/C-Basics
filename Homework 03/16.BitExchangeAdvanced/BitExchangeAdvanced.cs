using System;
class BitExchangeAdvanced
{
    static void Main()
    {
        // Input Data
        Console.Write("n = ");
        uint n = uint.Parse(Console.ReadLine()); // 1140867093
        Console.Write("p = ");
        int p = int.Parse(Console.ReadLine());   // 3
        Console.Write("q = ");
        int q = int.Parse(Console.ReadLine());   // 24
        Console.Write("k = ");
        int k = int.Parse(Console.ReadLine());   // 3

        // Execution
        if (Math.Abs(p - q) < k)
        {
            Console.WriteLine("overlapping");
        }
        else
        {
            if (((p + k - 1) > 31) || (q + k - 1 > 31))
            {
                Console.WriteLine("out of range");
            }
            else
            {
                // making mask with K bits of 1's (if k=3 => mask = 0000 0111).
                int mask = 0;
                for (int i = 1; i <= k; i++)
                {
                    mask = (mask << 1) | 1;
                }

                long firstMask = ((mask << p) & n) >> p;
                long secMask = ((mask << q) & n) >> q;
                long newNum = (~(mask << p)) & n; // change bits starting from position p to 0 (zero).
                newNum = (~(mask << q)) & newNum; // change bits starting from position q to 0 (zero).

                // move the mask to the correct position and replace 0's with correct bits' values
                newNum = newNum | (firstMask << q);
                newNum = newNum | (secMask << p);
                Console.WriteLine(newNum);
            }
        }
    }
}
