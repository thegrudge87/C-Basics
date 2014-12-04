using System;
class BitCopy
{
    static void Main()
    {
        // Input data
        int n = int.Parse(Console.ReadLine());
        byte p = byte.Parse(Console.ReadLine());

        // Execution
        int bit = (n & (1 << p)) >> p;
        //Console.WriteLine("num -> {0}", Convert.ToString(n, 2).PadLeft(32, '0'));
        //Console.WriteLine("bit -> {0}", Convert.ToString(bit, 2).PadLeft(32, '0'));
        if (bit == 0)
        {
            int output = n & (~(1 << 2));
            //Console.WriteLine("out -> {0}", Convert.ToString(output, 2).PadLeft(32, '0'));
            Console.WriteLine(output);
        }
        else
        {
            int output = n | (1 << 2);
            //Console.WriteLine("out -> {0}", Convert.ToString(output, 2).PadLeft(32, '0'));
            Console.WriteLine(output);
        }

    }
}