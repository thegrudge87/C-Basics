using System;
class FourDigitNumber
{
    static void Main()
    {
        int input = int.Parse(Console.ReadLine());  //2011
        int fourthDigit = input % 10; // 201 >>1
        int thirdDigit = (input / 10) % 10; // 20 >> 1
        int secondDigit = (input / 100) % 10; //2 >> 0
        int firstDigit = (input / 1000) % 10; //0 >> 2
        Console.WriteLine(firstDigit+secondDigit+thirdDigit+fourthDigit);
        Console.WriteLine("{3}{2}{1}{0}", firstDigit, secondDigit, thirdDigit, fourthDigit);
        Console.WriteLine("{3}{0}{1}{2}", firstDigit, secondDigit, thirdDigit, fourthDigit);
        Console.WriteLine("{0}{2}{1}{3}", firstDigit, secondDigit, thirdDigit, fourthDigit);

    }
}
