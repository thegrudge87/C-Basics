using System;
class BitsInverter
{
    static void Main()
    {
        // input
        int n = int.Parse(Console.ReadLine());
        int step = int.Parse(Console.ReadLine());
        int counter = 0;
        string output ="";

        // Loop for n numbers that will be inputted.
        for (int i = 0; i < n; i++)
        {
            int num = int.Parse(Console.ReadLine());  // 00101101
            // Loop that goes from all 8bits from left to right
            for (int bit = 7; bit >= 0; bit--)
            {
                counter++;
                if ((step==1) || (counter%step == 1))
                {
                    num = num ^ (1 << bit);
                }
            }
            output = output + num + "\n";
        }
        if (counter == 0)
        {
            Console.WriteLine("No");
        }
        else
        {
            Console.WriteLine(output);
        }
    }
}