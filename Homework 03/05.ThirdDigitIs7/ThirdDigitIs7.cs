using System;
class ThirdDigitIs7
{
    static void Main()
    {
        int input = int.Parse(Console.ReadLine());
        int thirdDigit = (input / 100) % 10;
        bool isItSeven = thirdDigit == 7;
        Console.WriteLine("Third digit is 7? {0}", isItSeven);
    }
}