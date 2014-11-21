using System;
using System.Globalization;
class WorkHours
{
    static void Main()
    {
        int reqHours = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        int availableDays = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        byte prodPerc = byte.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        int needHours = (int)(availableDays * (1 - 0.1) * 12.0 * prodPerc / 100.00);
        if ((needHours - reqHours) < 0)
        {
            Console.WriteLine("No\n{0}", needHours-reqHours);
        }
        else
        {
            Console.WriteLine("Yes\n{0}",needHours-reqHours);
        }
    }
}