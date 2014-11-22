using System;
class TheExplorer
{
    static void Main()
    {
        // n = diamond width
        int n = int.Parse(Console.ReadLine()); 

        for (int i = 0; i < n; i++)
        {
            // first and last line
            if (i == 0 || i == n - 1)
            {
                string outDiamond = new string('-', n / 2);
                Console.WriteLine("{0}{1}{0}", outDiamond, "*");
            }
            // the central line
            else if (i == (n/2))
            {
                string innerDiamond = new string('-', n - 2);
                Console.WriteLine("{0}{1}{0}", "*", innerDiamond);
            }
            // top of the diamond
            else if (i < (n/2))
            {
                string outDiamond = new string('-', n / 2 - i);
                string innerDiamond = new string('-', 2*(i-1)+1);
                Console.WriteLine("{0}{1}{2}{1}{0}", outDiamond, "*", innerDiamond);
            }
            // bottom of the diamond
            else
            {
                string outDiamond = new string('-', Math.Abs(n/2-i)); 
                // n-2 = count of the middle; 2*(i - n/2) - distance from the middle
                string innerDiamond = new string('-', Math.Abs(n-2 - 2*(i - n/2)));
                Console.WriteLine("{0}{1}{2}{1}{0}", outDiamond, "*", innerDiamond);
            }
        }
    }
}
