using System;
class WorkingHours
{
    static void Main()
    {
        int h = int.Parse(Console.ReadLine()); // required hours
        int d = int.Parse(Console.ReadLine()); // available days
        int p = int.Parse(Console.ReadLine()); // productivity percentage

        int efficiantHours = (int)((0.9 * d) * 12.0 * (p / 100.00));
        if ((efficiantHours - h) < 0)
        {
            Console.WriteLine("No");
            Console.WriteLine(efficiantHours - h);
        }
        else
        {
            Console.WriteLine("Yes");
            Console.WriteLine(efficiantHours - h);
        }
    }
}