using System;
class NewHouse
{
    static void Main()
    {
        // Input data
        byte n = byte.Parse(Console.ReadLine());

        // The roof
        for (int i = 0; i < n/2 + 1; i++)
        {
            string roofOutLine = new string('-', Math.Abs(n / 2 - i));
            string roof = new string('*', 2*i+1);
            Console.WriteLine("{0}{1}{0}",roofOutLine, roof);
        }

        // The house
        for (int i = 0; i < n; i++)
        {
            string corners = new string('|', 1);
            string walls = new string('*',n-2);
            Console.WriteLine("{0}{1}{0}", corners, walls);
        }
    }
}