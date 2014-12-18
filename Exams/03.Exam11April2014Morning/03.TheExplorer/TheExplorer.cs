using System;
class TheExplorer
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            // first & last line
            if ((i == 0) || (i == n - 1))
            {
                string outline = new string('-', n/2);
                Console.WriteLine("{0}*{0}", outline);
            }
                // central line
            else if (i == n/2)
            {
                string inner = new string('-', n-2);
                Console.WriteLine("*{0}*", inner);
            }
            else if (i < n/2)
            {
                string outLine = new string('-', n / 2 - i);
                string inLine = new string('-', (i - 1) * 2 + 1);
                Console.WriteLine("{0}*{1}*{0}", outLine, inLine);
            }
            else
            {
                string outline = new string('-', i - n/2);
                string inner = new string('-', (n - 2 - 2*(i - n/2)));
                Console.WriteLine("{0}*{1}*{0}", outline, inner);
            }
        }
    }
}