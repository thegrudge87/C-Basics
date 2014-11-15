using System;
class NullVariablesArithmetic
{
    static void Main()
    {
        int? nullInteger = null;
        double? nullDouble = null;

        Console.WriteLine("The value of the null integer is: {0};", nullInteger);
        Console.WriteLine("The value of the null double is: {0};", nullDouble);

        Console.WriteLine("Sum the variables with 5");
        Console.WriteLine("The value of the null integer is: {0};", nullInteger+5);
        Console.WriteLine("The value of the null double is: {0};", nullDouble+5);

        Console.WriteLine("Sum the variables with null literal");
        Console.WriteLine("The value of the null integer is: {0};", nullInteger + null);
        Console.WriteLine("The value of the null double is: {0};", nullDouble + null);

    }
}
