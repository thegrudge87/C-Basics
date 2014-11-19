using System;
class BitsExchange
{
    static void Main()
    {
        Console.Write("n = ");
        uint n = uint.Parse(Console.ReadLine());
        uint mask = 7;
        uint firstMask = ((mask << 3) & n) >> 3;
        uint secMask = ((mask << 24) & n) >> 24;
        long newNum = (~(mask << 3)) & n; // change bits #3, #4 and #5 to 0 (zero).
        newNum = (~(mask << 24)) & newNum; // change bits #24, #25 and #26 to 0 (zero).

        // move the mask to the correct position and replace 000 with correct bits' values
        newNum = newNum | (firstMask << 24);
        newNum = newNum | (secMask << 3);

        // newNum in 32bits
        //Console.WriteLine(Convert.ToString(newNum, 2).PadLeft(16, '0'));
        Console.WriteLine(newNum);
    }
}

