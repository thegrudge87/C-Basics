using System;
class PrimeNumberCheck
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int divisorCounter = 0;
        bool isPrime = false;

        //Check if the number is 0 or 1. If it's, it's not prime.
        if (n == 0 || n == 1)
        {
            isPrime = false;
        }
        else
        {
            // if it's not 0 or 1, check if the number is equal to any number less than it.
            for (int i = 2; i <= n; i++)
            {
                if (n % i == 0 && n != i)
                {
                    divisorCounter++;
                }
            }

            if (divisorCounter == 0)
            {
                isPrime = true;
            }
            else
            {
                isPrime = false;
            }
        }
        Console.WriteLine(isPrime);
    }
}
