using System;
class SumOfElements
{
    static void Main()
    {
        string[] elements = Console.ReadLine().Split(' ');
        long sumAllEl = 0;
        long maxEl = long.MinValue;

        for (int i = 0; i < elements.Length; i++)
        {
            long currEl = Convert.ToInt32(elements[i]);
            sumAllEl += currEl;
            maxEl = Math.Max(maxEl, currEl);
        }
        if ((sumAllEl - maxEl) == maxEl)
        {
            Console.WriteLine("Yes, sum={0}", sumAllEl-maxEl);
        }
        else
        {
            Console.WriteLine("No, diff={0}", Math.Abs(sumAllEl-2*maxEl));
        }
    }
}