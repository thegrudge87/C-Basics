using System;
class Sunglasses
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            //Check the row is it first or last.
            // if it is, we are writing only * for the frames of the sunglasses and a space between the shades.
            if (i == 1 || i==n)  
            {
                string frameTopBottom = new string('*', n * 2);
                string spaceBetween = new string(' ', n);
                Console.WriteLine("{0}{1}{0}",frameTopBottom, spaceBetween);
            }
            else
            {
                // Here we check is the current row is the one in the middles or not.
                // If it is, we are writing the bridge between the shades.
                if (i == (n+1)/2)
                {
                    string middleFrame = new string('*', 1);
                    string glass = new string('/', (n - 1) * 2);
                    string bridge = new string('|', n);
                    Console.WriteLine("{0}{1}{0}{2}{0}{1}{0}", middleFrame, glass, bridge);
                }
                else
                {
                    string middleFrame = new string('*', 1);
                    string glass = new string('/', (n - 1) * 2);
                    string spaceBetween = new string(' ', n);
                    Console.WriteLine("{0}{1}{0}{2}{0}{1}{0}", middleFrame, glass, spaceBetween);
                }
            }
        }
    }
}
