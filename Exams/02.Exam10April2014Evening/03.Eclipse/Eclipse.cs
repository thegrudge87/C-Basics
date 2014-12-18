using System;
class Eclipse
{
    static void Main()
    {
        // Input data
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            // First & last row
            if ((i == 0) || (i == n-1))
            {
                string frame = new string('*', (n-1)*2);
                string space = new string(' ', n - 1);
                Console.WriteLine(" {0} {1} {0} ", frame, space);
            }
            // Central line
            else if (i == n/2)
            {
                string lenses = new string('/', (n-1)*2);
                string bridge = new string('-', n-1);
                Console.WriteLine("*{0}*{1}*{0}*", lenses, bridge);
            }
            // Body
            else
            {
                string lenses = new string('/', (n - 1) * 2);
                string space = new string(' ', n - 1);
                Console.WriteLine("*{0}*{1}*{0}*", lenses, space);
            }
        }

    }
}