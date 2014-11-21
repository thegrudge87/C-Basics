using System;
class Program
{
    static void Main()
    {
        // input data
        Console.Write("start = ");
        int start = int.Parse(Console.ReadLine());
        Console.Write("end = ");
        int end = int.Parse(Console.ReadLine());
        int counter = 0;

        for (int i = start; i <= end; i++)
        {
            if (i % 5 == 0)
            {
                counter++;
            }
        }
        Console.WriteLine(counter);
    }
}