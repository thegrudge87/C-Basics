using System;
class StringsAndObjects
{
    static void Main()
    {
        string firstString = "Hello";
        string secondString = "World";
        object objMessage = firstString + " " + secondString;
        string fullMessage = (string)objMessage;
        Console.WriteLine("The message is - {0}", fullMessage);
    }
}

