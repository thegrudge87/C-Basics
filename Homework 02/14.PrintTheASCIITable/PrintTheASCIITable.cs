using System;
using System.Text;
class PrintTheASCIITable
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.Unicode;
        for (int i = 0; i <= 255; i++)
        {
            Console.WriteLine("{0} -> {1}", i, (char)i);
        }
    }
}

