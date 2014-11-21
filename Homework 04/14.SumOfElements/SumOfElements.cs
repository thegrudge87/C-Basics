using System;
class SumOfElements
{
    static void Main()
    {
        string[] inputLine = Console.ReadLine().Split(' ');
        int sum = 0;
        int maxEl = 0;
        foreach (var item in inputLine)
        {
            sum += int.Parse(item);
            maxEl = (int)Math.Max(int.Parse(item), maxEl);
        }
        if ((sum % 2 == 0) && sum / 2 == maxEl)
        {
            Console.WriteLine("Yes, sum={0}", sum/2);
        }
        else
        {
            Console.WriteLine("No, diff={0}", maxEl-(sum-maxEl));
        }
        
    }
}