using System;
class CatchTheBits
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int step = int.Parse(Console.ReadLine());

        int currentElemement = 0;
        int output = 0;
        int count = 0;

        // loop for the N elements that should be input;
        for (int i = 0; i < n; i++)
        {
            // input the current N element
            int inputNumber = int.Parse(Console.ReadLine());

            // loop goes through all 8 bits of the current element
            for (int bitN = 7; bitN >= 0; bitN--)
			{
                // check that the current element:
                // must be greater than equal element with 1. (1 + XX*step)
                // OR 
                // is the step = 1 AND in the same time the current element position is bigger than 0;
			    if ((currentElemement % step == 1) || (step == 1 & currentElemement > 0))
	            {
                    int bitValue = (inputNumber >> bitN) & 1;
                    output = (output << 1) | bitValue;
                    count++;
                    // check is there 8 bits in the output
                    // if there is we write it on the console and reset output and the bit counter.
                    if (count == 8)
	                {
                        Console.WriteLine(output);
                        output = 0;
                        count = 0;
	                }
	            }
                currentElemement++;
			}
        }
        // if there is a byte with less than 8 bits, we must add trailing zeroes from the right.
        if (count > 0)
	    {
            Console.WriteLine("{0}",(output << (8-count)));
	    }
    }
}
