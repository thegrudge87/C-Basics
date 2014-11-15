using System;
class OddOrEvenIntegers
{
    static void Main()
    {
        int n1 = 3;
        int n2 = 2;
        int n3 = -2;
        int n4 = -1;
        int n5 = 0;
        Console.WriteLine((Math.Abs(n1) % 2 == 1) ? n1 + " is it Odd? - True" : n1 + " is it Odd - False");
        Console.WriteLine((Math.Abs(n2) % 2 == 1) ? n2 + " is it Odd? - True" : n2 + " is it Odd - False");
        Console.WriteLine((Math.Abs(n3) % 2 == 1) ? n3 + " is it Odd? - True" : n3 + " is it Odd - False");
        Console.WriteLine((Math.Abs(n4) % 2 == 1) ? n4 + " is it Odd? - True" : n4 + " is it Odd - False");
        Console.WriteLine((Math.Abs(n5) % 2 == 1) ? n5 + " is it Odd? - True" : n5 + " is it Odd - False");
    }
}

