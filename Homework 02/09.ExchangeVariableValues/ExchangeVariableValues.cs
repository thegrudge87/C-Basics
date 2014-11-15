using System;
    class ExchangeVariableValues
    {
        static void Main()
        {
            int a = 5;
            int b = 10;
            int temp;
            Console.WriteLine("Starting values of the variables are: \na = {0} \nb = {1}", a, b);
            temp = a;
            a = b;
            b = temp;
            Console.WriteLine("After the exchange the new values of the variables are: \na = {0}\nb = {1}", a ,b);
            
        }
    }
