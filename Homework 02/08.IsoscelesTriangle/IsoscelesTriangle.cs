using System;
using System.Text;
class IsoscelesTriangle
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        char cSymbol = '\u00A9';
        Console.WriteLine("   " + cSymbol);
        Console.WriteLine("  " + cSymbol + " " + cSymbol);
        Console.WriteLine(" " + cSymbol + "   " + cSymbol);
        Console.WriteLine(cSymbol + " " + cSymbol + " " + cSymbol + " " + cSymbol);
    }
}
