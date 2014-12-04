using System;
class ConsoleGraphics
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        // Top of the bridge
        for (int i = 0; i < 2; i++)
        {
            string bridgeTop = new string('*', n * 2);
            Console.WriteLine(bridgeTop);
        }
        // Bottom of the bridge
        for (int i = 0; i < (n / 2) * 2; i++)
        {
            string col = new string('*', n / 2 + 1);
            string space = new string(' ', (n / 2) * 2);
            Console.WriteLine("{0}{1}{0}", col, space);
        }
        // Water
        for (int i = 0; i < 2; i++)
        {
            string bridgeTop = new string('~', n * 2);
            Console.WriteLine(bridgeTop);
        }
    }
}