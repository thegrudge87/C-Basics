using System;
class OddEvenSum
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int sumOdd = 0;
        int sumEven = 0;
        int k; // currenet input

        for (int i = 0; i < 2*n; i++)
        {
            k = int.Parse(Console.ReadLine());
            if ( i % 2 == 0 )
            {
                sumEven += k;                
            }
            else
            {
                sumOdd += k;
            }

        }
        if (sumEven == sumOdd)
        {
            Console.WriteLine("Yes, sum={0}", sumOdd);
        }
        else
        {
            Console.WriteLine("No, diff={0}", Math.Abs(sumOdd - sumEven));
        }
    }
}
