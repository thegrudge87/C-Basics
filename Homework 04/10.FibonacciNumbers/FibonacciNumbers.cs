using System;
class FibonacciNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int fibonacciNum_2 = 0;
        int fibonacciNum_1 = 0;
        int fibonacciNum = 0;
        for (int i = 0; i < n; i++)
        {
            switch (i)
            {
                case 0:
                    Console.Write("{0} ",0);
                    break;
                case 1:
                    Console.Write("{0} ", 1);
                    fibonacciNum_2 = 0;
                    fibonacciNum_1 = 1;
                    break;
                default:
                    fibonacciNum = fibonacciNum_2 + fibonacciNum_1;
                    Console.Write("{0} ", fibonacciNum);
                    fibonacciNum_2 = fibonacciNum_1;
                    fibonacciNum_1 = fibonacciNum;
                    break;
            }
        }
        Console.WriteLine();
    }
}