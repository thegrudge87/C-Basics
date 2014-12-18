using System;
class Nums
{
    static void Main()
    {
        // Input data
        int start = int.Parse(Console.ReadLine());
        int end = int.Parse(Console.ReadLine());

        for (int i = start; i <= end; i++)
        {
            if (i%2 == 0)
            {
                Console.WriteLine("{0:F3}", Math.Sqrt(i));
                //Console.WriteLine("{0:F3}", Math.Pow(i, 2));
            }
            else
            {
                //Console.WriteLine("{0:F3}", Math.Sqrt(i));
                Console.WriteLine("{0:F3}", Math.Pow(i, 2));
            }
        }
    }
}
