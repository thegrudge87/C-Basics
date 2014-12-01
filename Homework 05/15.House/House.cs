using System;

class House
{
    static void Main()
    {
        // input data
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n/2+1; i++)
        {
            // the top of the roof
            if (i == 0)
            {
                string outL = new string('.', n/2);
                Console.WriteLine("{0}*{0}", outL);
            }
            // the bottom of the roof
            else if (i == n/2)
            {
                string roofLine = new string('*', n);
                Console.WriteLine("{0}", roofLine);
            }
            // middle part of the roof
            else
            {
                string outLine = new string('.', n/2-i);
                string inLine = new string('.', 2*i-1);
                Console.WriteLine("{0}*{1}*{0}", outLine, inLine);
            }
        }
        // Walls of the building
        for (int i = 0; i < n/2; i++)
        {
            // If it's NOT the bottom row of bricks.
            if(!(i == n/2-1))
            {
                string outWall = new string('.', n / 4);
                string inHouse = new string('.', n - 2*(n/4) - 2);
                Console.WriteLine("{0}*{1}*{0}", outWall, inHouse);
            }
            // If "i" is the bottom row of the bricks.
            else
            {
                string outWall = new string('.', n / 4);
                string bottomHouseLine = new string('*', n - 2*(n / 4));
                Console.WriteLine("{0}{1}{0}", outWall, bottomHouseLine);
            }
        }
    }
}