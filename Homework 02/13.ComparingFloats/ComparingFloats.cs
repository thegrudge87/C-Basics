using System;
class ComparingFloats
{
    static void Main()
    {
        float a = 5.3f;
        float b = 6.01f;
        float eps = 0.000001f;
        float diff = Math.Abs(a - b);
        bool comprAB = diff < eps;
        //Console.WriteLine("Are float numbers A & B are equal: {0}", comprAB);
        Console.WriteLine("a= {0:#.########} | b={1} | Equal: {2} | Difference: {3} |", a, b, comprAB, diff);

        //For the other numbers in the table 
        a = 5.00000001f;
        b = 5.00000003f;
        diff = Math.Abs(a - b);
        comprAB = diff < eps;
        Console.WriteLine("a= {0:#.########} | b={1} | Equal: {2} | Difference: {3} |", a,b,comprAB, diff);
        a = 5.00000005f;
        b = 5.00000001f;
        diff = Math.Abs(a - b);
        comprAB = diff < eps;
        Console.WriteLine("a= {0:#.########} | b={1:#.########} | Equal: {2} | Difference: {3} |", a, b, comprAB, diff);
        a = -0.0000007f;
        b = 0.00000007f;
        diff = Math.Abs(a - b);
        comprAB = diff < eps;
        Console.WriteLine("a= {0:#.########} | b={1:#.########} | Equal: {2} | Difference: {3} |", a, b, comprAB, diff);
        a = -4.999999f;
        b = -4.999998f;
        diff = Math.Abs(a - b);
        comprAB = diff < eps;
        Console.WriteLine("a= {0:#.######} | b={1:#.######} | Equal: {2} | Difference: {3} |", a, b, comprAB, diff);
        a = 4.999999f;
        b = 4.999998f;
        diff = Math.Abs(a - b);
        comprAB = diff < eps;
        Console.WriteLine("a= {0:#.######} | b={1:#.######} | Equal: {2} | Difference: {3} |", a, b, comprAB, diff);
    }
}

