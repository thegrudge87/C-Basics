using System;
class TheExplorer
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine()); // n = diamond width

        for (int i = 0; i < n; i++)
        {
            if (i == 0 || i == n - 1)
            {
                // first and last line
                string outDiamond = new string('-', n / 2);
                string diamondLine = new string('*', 1);
                Console.WriteLine("{0}{1}{0}", outDiamond, diamondLine);
            }
            else
            {
                // the central line
                if (i == (n/2))
                {
                    string diamondLine = new string('*', 1);
                    string innerDiamond = new string('-', n - 2);
                    Console.WriteLine("{0}{1}{0}", diamondLine, innerDiamond);
                }
                else
                {
                    // top of the diamond
                    if (i < (n/2))
                    {
                        string outDiamond = new string('-', n / 2 - i);
                        string diamondLine = new string('*', 1);
                        string innerDiamond = new string('-', 2*(i-1)+1);
                        Console.WriteLine("{0}{1}{2}{1}{0}", outDiamond, diamondLine, innerDiamond);
                    }
                    else
                    {
                        // bottom of the diamond
                        string outDiamond = new string('-', Math.Abs(n/2-i)); 
                        string diamondLine = new string('*', 1);
                        // n-2 = count of the middle; 2*(i - n/2) - distance from the middle
                        string innerDiamond = new string('-', Math.Abs(n-2 - 2*(i - n/2))); 
                        Console.WriteLine("{0}{1}{2}{1}{0}", outDiamond, diamondLine, innerDiamond);
                    }
                }
            }
        }
    }
}
