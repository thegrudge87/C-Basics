using System;
class Sunglasses
{
    static void Main()
    {
        // Input data
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            if ((i == 0) || (i == n-1))
            {
                string frame = new string('*', n*2);
                string space = new string(' ', n);
                Console.WriteLine("{0}{1}{0}", frame, space);
            }
            else if (i == n/2)
            {
                string glass = new string('/',n*2-2);
                string bridge = new string('|', n);
                Console.WriteLine("*{0}*{1}*{0}*", glass, bridge);
            }
            else
            {
                string glass = new string('/', n * 2 - 2);
                string space = new string(' ', n);
                Console.WriteLine("*{0}*{1}*{0}*", glass, space);
            }
        }
    }
}