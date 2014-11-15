using System;
class JoroTheFootballPlayer
{
    static void Main()
    {
        int allWeekends = 52;

        // In this part we are receiving data is the year leap or not. 
        // Also we are checking the input to avoid mistakes.
        /* 
            Here we use "Convert.ToChar" because the data that "Console.ReadLine()" give is in type string. 
            But we want ot check if the input data is the symbol T or F. 
            And symbols are in type char
        */
        //Console.WriteLine(@"Is the year leap? Answer with ""t"" for true and with ""f"" for false.");
        char leapAns = Convert.ToChar(Console.ReadLine());
        int leapExtraPlays = 0;
        if (leapAns == 't' | leapAns == 'T')
        {
            leapExtraPlays = 3;
        }
        else
        {
            if (leapAns == 'f' | leapAns == 'F')
            {
                leapExtraPlays = 0;
            }
            else
            {
                Console.WriteLine(">>ERROR<< Incorrect input!");
            }
        }

        // Input the number of holidays in the year (which are not Saturday or Sunday).
        /* 
            Here we use "Convert.ToInt32" because the data that "Console.ReadLine()" give is in type string. 
            But we want to get the number of the holidays as an integer.
        */
        //Console.WriteLine("Number of holidays in the year (which are not Saturday or Sunday).");
        int holidays = Convert.ToInt32(Console.ReadLine());  // The variable "holidays" is "p" in the terms of the task

        // Input of how many times Joro goes at his homtown. 
        /* 
            Here we use "Convert.ToInt32" because the data that "Console.ReadLine()" give is in type string. 
            But we want to get the number of the weekends that Joro goes in his hometown as an integer.
        */
        //Console.WriteLine("How many times Joro goes at his hometown? ");

        int homeWeekends = Convert.ToInt32(Console.ReadLine()); // The variable "homeWeekends" is "h" in the terms of the task.

        //Counting Part.
        int output = (allWeekends - homeWeekends) * 2 / 3 + holidays / 2 + homeWeekends + leapExtraPlays;
        //Console.WriteLine("Joro will play {0} time football", output);
        Console.WriteLine(output);
    }
}

