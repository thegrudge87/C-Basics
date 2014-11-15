using System;
class DivideBy7And5
{
    static void Main()
    {
        int inVar = int.Parse(Console.ReadLine());
        bool isEquel7n5 = (inVar > 0) && (inVar % 7 == 0) && (inVar % 5 == 0);
        Console.WriteLine("{0} - divided by 7 & 5 -> {1}", inVar, isEquel7n5);
    }
}
