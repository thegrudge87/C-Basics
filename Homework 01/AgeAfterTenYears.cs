using System;
class AgeAfterTenYears
{
    static void Main()
    {
        Console.Write("Enter your birthday date (in format yyyy/mm/dd): ");
        DateTime birthDate = DateTime.Parse(Console.ReadLine());
        DateTime todayDate = DateTime.Now;
        int age = todayDate.Year - birthDate.Year;
        double fullAge = (double)(todayDate - birthDate).TotalDays / 365.242199D;
        Console.WriteLine("You are {0} years old.", age);
        Console.WriteLine("You accurete age is {0}",fullAge);
    }
}
