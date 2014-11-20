using System;
using System.Globalization;
class SumOf5Numbers
{
    static void Main()
    {
        //string line = Console.ReadLine();
        string[] numLine = Console.ReadLine().Split(' ');
        float sum = 0;
        for (int i = 0; i < numLine.Length; i++)
        {
            sum += float.Parse(numLine[i], CultureInfo.InvariantCulture);
        }
        Console.WriteLine(sum);
    }
}