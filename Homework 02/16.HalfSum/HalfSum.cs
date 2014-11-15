using System;
class HalfSum
{
    static void Main()
    {
        int countNum = int.Parse(Console.ReadLine());
        int sum1 = 0;
        int sum2 = 0;
        for (int i = 1; i <= countNum*2; i++ )
        {
            if (i >= 1 && i <= countNum)
            {
                sum1 = sum1 + (int.Parse(Console.ReadLine()));
            }
            else 
            {
                sum2 = sum2 + (int.Parse(Console.ReadLine()));
            }
        }

        if (sum1 == sum2)
        {
            Console.WriteLine("Yes, sum={0}", sum1);
        }
        else
        {
            Console.WriteLine("No, diff={0}", Math.Abs(sum1 - sum2));
        }
    }
}
