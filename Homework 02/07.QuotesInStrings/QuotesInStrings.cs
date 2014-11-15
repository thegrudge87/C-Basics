using System;
class QuotesInStrings
{
    static void Main()
    {
        string firstString = "The \"use\" of quotations causes difficulties.";
        string secondString = @"The ""use"" of quotations causes difficulties.";
        Console.WriteLine("The strings are: \n{0}\nand\n{1}\n", firstString, secondString);
    }
}

