using System;
class Pairs
{
    static void Main()
    {
        string[] inputLine = Console.ReadLine().Split(' ');

        int pairValue = 0;
        int maxDiff = int.MinValue;
        bool isEqual = true;
        int prevPairVal = 0;

        // Cicle checking all pairs. The step is 2 elements [i = i + 2], not 1 [i++]
        for (int i = 0; i < inputLine.Length; i = i+2)
        {
            // If it's the first literation we get the pair value and assigned it as previous pair value. 
            if (i == 0)
            {
                pairValue = int.Parse(inputLine[i]) + int.Parse(inputLine[i+1]);
                prevPairVal = pairValue;
            }
            // For every next cicle literation after the first one.
            else
            {
                int currPairVal = int.Parse(inputLine[i]) + int.Parse(inputLine[i + 1]);
                // If the current pair value is NOT equal to the pair value
                if (!(currPairVal == pairValue))
                {
                    isEqual = false;
                    maxDiff = Math.Max(Math.Abs(currPairVal - prevPairVal), maxDiff);
                    prevPairVal = currPairVal;
                }
            }
        }
        // The output
        if (isEqual == true)
        {
            Console.WriteLine("Yes, value={0}", pairValue);
        }
        else
        {
            Console.WriteLine("No, maxdiff={0}", maxDiff);
        }
    }
}