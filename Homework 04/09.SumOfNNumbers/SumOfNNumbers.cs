using System;
using System.Globalization;
    class SumOfNNumbers
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            double sum = 0.0;
            for (int i = 0; i < n; i++)
            {
                sum += double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); 
            }
            Console.WriteLine(sum);
        }
    }