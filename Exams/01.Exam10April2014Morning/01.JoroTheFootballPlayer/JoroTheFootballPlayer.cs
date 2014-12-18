using System;
class JoroTheFootballPlayer
{
    static void Main()
    {
        // Input date.
        string isYeap = Console.ReadLine();
        int p = int.Parse(Console.ReadLine());
        int h = int.Parse(Console.ReadLine());

        int leapYearPlays = 0;
        if ((isYeap == "t") || (isYeap == "T"))
        {
            leapYearPlays = 3;
        }
        else
        {
            leapYearPlays = 0;
        }

        double totalPlays = h + (52 - h) * (2.0 / 3.0) + (1.0 / 2.0) * p + leapYearPlays;
        Console.WriteLine((int)totalPlays);
    }
}