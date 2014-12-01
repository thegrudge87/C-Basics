using System;
class MagicDates
{
    static void Main()
    {
        // Input data
        int startYear = int.Parse(Console.ReadLine());
        int endYear = int.Parse(Console.ReadLine());
        int magicWeight = int.Parse(Console.ReadLine());

        // Setting the start & end dates.
        DateTime startDate = new DateTime(startYear, 1, 1);
        DateTime endDate = new DateTime(endYear, 12, 31);
        
        // Set counter which will count the existing magic dates.
        int magicDateCount = 0;

        // Loop for every date in the period we have
        for (DateTime date = startDate; date <= endDate; date = date.AddDays(1))
        {
            int dayDigitOne = date.Day / 10;
            int dayDigitTwo = date.Day % 10;
            int monthDigitOne = date.Month / 10;
            int monthDigitTwo = date.Month % 10;
            int yearDigitOne = date.Year / 1000;
            int yearDigitTwo = (date.Year / 100) % 10;
            int yearDigitThree = (date.Year / 10) % 10;
            int yearDigitFour = date.Year % 10;
            int weight = 0;
            // Create an int array so we can loop it
            int[] digits = { dayDigitOne, dayDigitTwo, monthDigitOne, monthDigitTwo, yearDigitOne, yearDigitTwo, yearDigitThree, yearDigitFour };

            // Loop circulate through all elements of the array
            for (int i = 0; i <= digits.Length; i++)
            {
                // loop starts from the element after the element of the parent loop, to the end of the array
                for (int y = i+1; y < digits.Length; y++)
                {
                    weight += digits[i] * digits[y];
                }
            }
            // Check is the weight that current date has is equal to the magic weight from the input.
            if (weight == magicWeight)
            {
                Console.WriteLine("{0:d2}-{1:d2}-{2:d2}", date.Day, date.Month, date.Year);
                magicDateCount++;
            }
        }

        // If there is no registered existing magic date in the period.
        if (magicDateCount == 0)
        {
            Console.WriteLine("No");
        }
    }
}