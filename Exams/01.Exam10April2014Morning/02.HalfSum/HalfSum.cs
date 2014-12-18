using System;
class HalfSum
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int frstSum = 0;
        int scndSum = 0;
        for (int i = 0; i < 2*n; i++)   
        {
            int num = int.Parse(Console.ReadLine());
            if (i < n)
            {
                frstSum += num;
            }
            else
            {
                scndSum += num;
            }
        }
        if (frstSum == scndSum)
        {
            Console.WriteLine("Yes, sum={0}", frstSum);
        }
        else
        {
            Console.WriteLine("No, diff={0}", Math.Abs(frstSum-scndSum));
        }
    }
}