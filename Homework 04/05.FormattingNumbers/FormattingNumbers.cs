using System;
using System.Globalization;
class FormattingNumbers
{
    static void Main()
    {
        // Input data
        Console.Write("a = ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("b = ");
        float b = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.Write("c = ");
        float c = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        // {0, -10:X}  -> -10 is for left-aligment with 10 symbols; X - shows that it's Hex;
        // {1, 10} -> 10 is for right-aligmnet with 10 symbols space;
        // {2, 10:F2} -> 10 is for right-aligmnet with 10 symbols space; F2 - float with 2 digits after the decimal point;
        // {3, -10:F3} -> -10: left-aligment with 10 symbols; F3 - float with 3 digits after the decimal point;
        Console.WriteLine("|{0, -10:X}|{1,10}|{2, 10:F2}|{3, -10:F3}|", 
                            Convert.ToInt32(a), 
                            Convert.ToString(a, 2).PadLeft(10, '0'), 
                            b, 
                            c);
    }
}