using System;
class SumOfElements
{
    static void Main()
    {
        string[] inputLine = Console.ReadLine().Split(' ');
        long sum = 0;
        long maxEl = long.MinValue;
        for (int i = 0; i < inputLine.Length; i++ )
        {
            sum += long.Parse(inputLine[i]);
            maxEl = (long)Math.Max(long.Parse(inputLine[i]), maxEl);
        }

        if (sum == 2 * maxEl)
        {
            Console.WriteLine("Yes, sum={0}", sum/2);
        }
        else
        {
            Console.WriteLine("No, diff={0}", Math.Abs(maxEl-(sum-maxEl)));
        }
        
    }
}