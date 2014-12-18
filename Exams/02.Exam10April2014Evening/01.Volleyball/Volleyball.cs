using System;
class Volleyball
{
    static void Main()
    {
        // Input data
        string yearType = Console.ReadLine();
        int p = int.Parse(Console.ReadLine());
        int h = int.Parse(Console.ReadLine());

        double addLeapPlays = 0.0f;
        switch (yearType)
        {
            case "leap":
                addLeapPlays = 0.15f;
                break;
            case "normal":
                addLeapPlays = 0.0f;
                break;
        }
        double totalPlays = (h + (48 - h) * (3.0 / 4.0) + p * (2.0 / 3.0))*(1+addLeapPlays);
        Console.WriteLine((int)totalPlays);
    }
}