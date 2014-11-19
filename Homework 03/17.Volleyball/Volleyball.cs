using System;
class Volleyball
{
    static void Main()
    {
        // Input Data
        string yearType = Console.ReadLine();         // <-- input is the year is leap or normal
        ushort p = ushort.Parse(Console.ReadLine());  // <-- holidays
        byte h = byte.Parse(Console.ReadLine());      // <-- hometown weekends

        bool isLeap = (yearType == "leap" ? true : false);

        // all weekends = 48; [constant]
        // holiday plays = 2/3 * p
        // hometown plays = 1 * h
        // normal weeknends = (all weeknends - hometown weekends) * 3/4; [he is not at work on 3/4 of the weekends]
        // all plays for normal year = 1*h + (48 - h)*3/4 + p*2/3

        // if the year is leap  
        // total plays for leap = all plays[normal year] + 15% * all plays[normal year] = 1.15 * all plays[normal year] 
        // the number of plays must be rounded down so -> (int)total plays for leap 

        // We must delete and multiply to 1.0, 2.0 & etc, because we need to get more accurate results.
        double totalPlaysN = 1.0 * h + (48 - h) * 3.0 / 4.0 + p * 2.0 / 3.0;        
        Console.WriteLine( (isLeap == false) ? (int)totalPlaysN : (int)(totalPlaysN*1.15) );
    }
}
